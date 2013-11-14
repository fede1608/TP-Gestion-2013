using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ClasesDatosTablas;
using Clinica_Frba.Sql;
using Clinica_Frba.Menu;

namespace Clinica_Frba.Abm_de_Profesional_Alta
{
    public partial class frm_ABMpro_Alta : Form
    {
        //Profesional profesional;
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        Profesional prof;
        bool Mod = false;
        public frm_ABMpro_Alta()
        {    
            InitializeComponent();
 
        }

        public frm_ABMpro_Alta(Profesional p)//Modificacion
        {
            InitializeComponent();
            prof = p;
            Mod = true;
            
        }

        private void cargarDatos(Profesional prof)
        {
            txt_ABMpro_NDoc.Text = prof.pro_dni.ToString();
            txt_ABMpro_apellido.Text = prof.pro_apellido;
            txt_ABMpro_direccion.Text = prof.pro_direccion;
            txt_ABMpro_mail.Text = prof.pro_mail;
            txt_ABMpro_matricula.Text = prof.pro_matricula.ToString();
            txt_ABMpro_nombre.Text = prof.pro_nombre;
            txt_ABMpro_telefono.Text = prof.pro_telefono.ToString();
            cbo_ABMpro_sexo.SelectedIndex = (prof.pro_sexo == "M" || prof.pro_sexo == "m") ? 0 : 1;
            dateTimePicker1.Value = prof.pro_nacimiento;
            //txt_ABMpro_nombre.Enabled = false;
            txt_ABMpro_NDoc.Enabled = false;
            //txt_ABMpro_apellido.Enabled = false;

            foreach (Especialidad esp in prof.especialidades())
            {
                //foreach (Especialidad esp2 in chlb_especialidades.Items)
                for (int i =0;i<chlb_especialidades.Items.Count;i++)
                {
                    Especialidad esp2 = (Especialidad)chlb_especialidades.Items[i];
                    if (esp.esp_id == esp2.esp_id)
                    {
                        chlb_especialidades.SetItemChecked(chlb_especialidades.Items.IndexOf(esp2),true);
                    }
                }
            }
        }


        private void btn_ABMpro_Aceptar_Click(object sender, EventArgs e)
        {
            //Validamos que los datos esten completos
            if (txt_ABMpro_nombre.Text != ""
                  && txt_ABMpro_apellido.Text != ""
                  && txt_ABMpro_NDoc.Text != ""
                  && txt_ABMpro_matricula.Text != ""
                  && txt_ABMpro_direccion.Text != ""
                  && txt_ABMpro_telefono.Text != ""
                  && txt_ABMpro_mail.Text != ""
                  && cbo_ABMpro_sexo.Text != ""
                  && chlb_especialidades.CheckedItems.Count > 0
                  )
            {
                
                
                //Se revisa que la matricula no haya sido asignada previamente
                var cantidadMat = runner.Single("SELECT COUNT(*) as ocurrencias FROM SIGKILL.profesional WHERE pro_matricula='{0}'", txt_ABMpro_matricula.Text);
                if ((int)cantidadMat["ocurrencias"] != 0)
                    {
                        MessageBox.Show("La matricula ingresada ya se encuentra asignada a otro profesional.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                 

                //Se revisa que el DNI no haya sido asignado previamente
                var cantidadDoc = runner.Single("SELECT COUNT(*) as ocurrencias FROM SIGKILL.profesional WHERE pro_dni='{0}'", txt_ABMpro_NDoc.Text);
                if ((int)cantidadDoc["ocurrencias"] != 0)
                {
                    MessageBox.Show("El documento ingresado ya se encuentra asignado a otro profesional.",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Cambiamos el contenido del comboBox de elección de sexo acorde al formato que admite la columna en la BD
                char sexo;
                if (cbo_ABMpro_sexo.Text == "Masculino") {sexo='M';} else {sexo='F';}

                //Si llegamos a este punto, ya esta controlado que el profesional no tenga datos
                //repetidos, por lo que procedemos a crearle un usuario primero si es que no lo tiene
                Usuario user;
                string nombre_usuario = "u" + Convert.ToString(txt_ABMpro_NDoc.Text);
                var existeUsuario = runner.Single("SELECT COUNT(*) as ocurrencias FROM SIGKILL.usuario WHERE usr_usuario='{0}'", nombre_usuario);
                
                if ((int)existeUsuario["ocurrencias"] == 0)
                {
                    //Si NO existe un usuario con el mismo documento
                    //MessageBox.Show("No existe un usuario para este profesional");

                    //Creamos un usuario default para el profesional
                    //Un usuario default de profesional tiene como usuario uDNI (uXXX) y como pass su MATRICULA
                    
                    try
                    {
                        runner.Insert("INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)" +
                            "VALUES ('{0}','{1}')", nombre_usuario, toSha256.ToSha256(txt_ABMpro_matricula.Text));
                        MessageBox.Show("Se creo el usuario: "+nombre_usuario+" para el profesional");
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al crear el usuario default",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                user = new Adapter().Transform<Usuario>(runner.Single("SELECT * FROM SIGKILL.Usuario WHERE usr_usuario='{0}'", nombre_usuario));

                //En este punto ya estamos seguros de que existe un usuario para el profesional, 
                //por lo que ya podemos agregarlo   
                try
                {
                    //TODO: Revisar la sintaxis de esto (sobre todo las variables)
                    runner.Insert("INSERT INTO SIGKILL.profesional(pro_matricula,pro_usuario,pro_nombre,pro_apellido, pro_dni, pro_direccion, pro_telefono, pro_mail, pro_nacimiento, pro_sexo)"
                   + " VALUES ({0}, {1}, '{2}', '{3}',{4},'{5}',{6},'{7}',{8},'{9}')",
                    int.Parse(txt_ABMpro_matricula.Text), user.usr_id, txt_ABMpro_nombre.Text, txt_ABMpro_apellido.Text,
                    int.Parse(txt_ABMpro_NDoc.Text), txt_ABMpro_direccion.Text, int.Parse(txt_ABMpro_telefono.Text), txt_ABMpro_mail.Text,
                    dateTimePicker1.Value.ToString("yyyy-MM-dd"), sexo);

                    Profesional pro = new Adapter().Transform<Profesional>(runner.Single("SELECT * FROM SIGKILL.Profesional WHERE pro_dni={0}", txt_ABMpro_NDoc.Text));
                    foreach (Especialidad esp in chlb_especialidades.CheckedItems)
                    {
                        runner.Insert("INSERT INTO SIGKILL.esp_prof (espprof_profesional,espprof_especialidad)" +
                            "VALUES ({0},{1})", pro.pro_id, esp.esp_id);
                    }

                    MessageBox.Show("El profesional fue dado de alta satisfactoriamente.",
"Operación válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al dar de alta el profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            }
            //En el caso de que falten ingresar datos, se procedera a informar al usuario
            else
            {
                MessageBox.Show("Por favor, complete todos los datos para continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }


        private void btn_ABMpro_limpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos todos los campos del formulario
            txt_ABMpro_nombre.Clear();
            txt_ABMpro_apellido.Clear();
            txt_ABMpro_matricula.Clear();
            txt_ABMpro_NDoc.Clear();
            txt_ABMpro_direccion.Clear();
            txt_ABMpro_telefono.Clear();
            txt_ABMpro_mail.Clear();

        }



        private void txt_ABMpro_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ABMpro_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbox_ABMpro_nuevoProfesional_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ABMpro_NDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_ABMpro_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_ABMpro_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void frm_ABMpro_Alta_Load(object sender, EventArgs e)
        {
            IList<Especialidad> esp = new Adapter().TransformMany<Especialidad>(runner.Select("SELECT * FROM SIGKILL.especialidad"));
            foreach (Especialidad es in esp)
            {
                chlb_especialidades.Items.Add(es);
            }
            if (Mod)
            {
                cargarDatos(prof);
                btn_ABMpro_aceptar.Visible = false;
                btn_ABMpro_limpiar.Visible = false;
                btn_ABMpro_actualizar.Visible = true;
                Text = "Modificacion Profesionales";

            }
        }

        private void btn_ABMpro_actualizar_Click(object sender, EventArgs e)
        {
                        //Validamos que los datos esten completos
            if (txt_ABMpro_nombre.Text != ""
                  && txt_ABMpro_apellido.Text != ""
                  && txt_ABMpro_NDoc.Text != ""
                  && txt_ABMpro_matricula.Text != ""
                  && txt_ABMpro_direccion.Text != ""
                  && txt_ABMpro_telefono.Text != ""
                  && txt_ABMpro_mail.Text != ""
                  && cbo_ABMpro_sexo.Text != ""
                  && chlb_especialidades.CheckedItems.Count > 0
                  )
            {
                Profesional p2 = new Profesional();
                p2.pro_id = prof.pro_id;
                p2.pro_apellido = txt_ABMpro_apellido.Text;
                p2.pro_direccion = txt_ABMpro_direccion.Text;
                p2.pro_mail = txt_ABMpro_mail.Text;
                p2.pro_matricula = int.Parse(txt_ABMpro_matricula.Text);
                p2.pro_nacimiento = dateTimePicker1.Value;
                p2.pro_nombre = txt_ABMpro_nombre.Text;
                string sexo;
                if (cbo_ABMpro_sexo.Text == "Masculino") { sexo = "M"; } else { sexo = "F"; }
                p2.pro_sexo = sexo;
                p2.pro_telefono = int.Parse(txt_ABMpro_telefono.Text);
                try
                {
                    p2.actualizar(prof,chlb_especialidades.CheckedItems.OfType<Especialidad>().ToList());
                    MessageBox.Show("Se han actualizado correctamente los datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
                MessageBox.Show("Por favor, complete todos los datos para continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
