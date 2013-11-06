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


                //Si llegamos a este punto, ya esta controlado que el profesional no tenga datos
                //repetidos, por lo que procedemos a crearle un usuario primero si es que no lo tiene
                string nombre_usuario = "u" + Convert.ToString(txt_ABMpro_NDoc.Text);
                var existeUsuario = runner.Single("SELECT COUNT(*) as ocurrencias FROM SIGKILL.usuario WHERE usr_usuario='{0}'", nombre_usuario);
                if ((int)existeUsuario["ocurrencias"] != 0)
                {
                    //Si existe un usuario con el mismo documento
                    MessageBox.Show("el usuario ya exisite");
                }
                
                /*runner.Insert("INSERT INTO SIGKILL.rol(rol_nombre,rol_habilitado) VALUES ('{0}',{1})", txtNombre.Text, hab.ToString());
                var res = runner.Single("SELECT * FROM SIGKILL.rol WHERE rol_nombre='{0}'", txtNombre.Text);
                Rol newrol = new Adapter().Transform<Rol>(res);
                foreach (var f in checkedListBox1.CheckedItems)
                {
                    runner.Insert("INSERT INTO SIGKILL.func_rol(frol_rol,frol_funcionalidad) VALUES ({0},{1})", newrol.rol_id.ToString(), (checkedListBox1.Items.IndexOf(f) + 1).ToString());
                }
                */
                

                MessageBox.Show("El profesional fue dado de alta satisfactoriamente.",
                "Operación válida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                 
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


    }
}
