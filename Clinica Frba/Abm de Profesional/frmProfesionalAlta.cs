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

        public frm_ABMpro_Alta()
        {    
            InitializeComponent();

            
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
                string nombre_usuario = "u" + Convert.ToString(txt_ABMpro_NDoc.Text);
                var existeUsuario = runner.Single("SELECT COUNT(*) as ocurrencias FROM SIGKILL.usuario WHERE usr_usuario='{0}'", nombre_usuario);
                if ((int)existeUsuario["ocurrencias"] == 0)
                {
                    //Si NO existe un usuario con el mismo documento
                    MessageBox.Show("No existe un usuario para este profesional");

                    //Creamos un usuario default para el profesional
                    //Un usuario default de profesional tiene como usuario uDNI (uXXX) y como pass su MATRICULA
                    try
                    {
                        runner.Insert("INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)" +
                            "VALUES ('{0}','{1}')", nombre_usuario, toSha256.ToSha256(txt_ABMpro_matricula.Text));
                        MessageBox.Show("Se creo un usuario default para el profesional");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al crear el usuario default",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }


                //En este punto ya estamos seguros de que existe un usuario para el profesional, 
                //por lo que ya podemos agregarlo   
                try
                {
                    //TODO: Revisar la sintaxis de esto (sobre todo las variables)
                    runner.Insert("INSERT INTO SIGKILL.profesional(pro_matricula,pro_usuario,pro_nombre,pro_apellido, pro_dni, pro_direccion, pro_telefono, pro_mail, pro_nacimiento, pro_sexo, pro_cant_hs_acum) VALUES {0}, '{1}', '{2}', '{3}',{4},'{5}',{6},'{7}','{8}','{9}',{10}",
                    int.Parse(txt_ABMpro_matricula.Text), nombre_usuario, txt_ABMpro_nombre.Text, txt_ABMpro_apellido.Text,
                    int.Parse(txt_ABMpro_NDoc.Text), txt_ABMpro_direccion.Text, int.Parse(txt_ABMpro_telefono.Text), txt_ABMpro_mail.Text,
                    monthCalendar_ABMpro_calendario.SelectionRange.Start.ToString("yyyy-MM-dd"), sexo, 0);

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

        private void monthCalendar_ABMpro_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

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


    }
}
