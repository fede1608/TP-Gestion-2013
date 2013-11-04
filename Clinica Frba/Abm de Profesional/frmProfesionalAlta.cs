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
                /*
                int dni = int.Parse(txt_ABMAfiliado_AltaMod_nrodoc.Text);
                int telefono = int.Parse(txt_ABMAfiliado_AltaMod_telefono.Text);
                string nombre_usuario = "u" + Convert.ToString(txt_ABMAfiliado_AltaMod_nrodoc.Text);
                    
                    SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
                    //TODO: parsear datos y terminar el insert
                    try
                    {
                        var result = runner
                            .Single("INSERT INTO SIGKILL.Usuario WHERE usr_usuario= '{0}' ", txtUser.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Error al crear el nuevo afiliado");
                    }
                 */
            }
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
