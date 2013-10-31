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

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class frm_ABMpro_Alta : Form
    {
        public frm_ABMpro_Alta()
        {    
            InitializeComponent();

            //Dependiendo de dónde lo llamen
            //tiene que decidir qué componentes visualiza
            //Por default es la primer Alta
            Boolean alta = true;
            if (alta)
            {
                Text = "Alta";
                btn_ABMpro_aceptar.Enabled = false;
                gbox_nuevoProfesional.Text = "Alta afiliado";
            }
            else
            {
                Text = "Modificación";
                gbox_nuevoProfesional.Text = "Modificación Afiliado";
                //Estos campos no se pueden modificar
                txt_ABMpro_nombre.Enabled = false;
                txt_ABMpro_apellido.Enabled = false;
                txt_ABMpro_NDoc.Enabled = false;
                monthCalendar_ABMpro_calendario.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cbo_ABMAfiliado_Alta_nacdia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void upd_ABMAfiliado_AltaMod_dia_ValueChanged(object sender, EventArgs e)
        {

        }


        private void cbo_ABMAfiliado_Alta_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ABMAfiliado_Alta_siguiente_Click(object sender, EventArgs e)
        {
            /*if(cbo_ABMAfiliado_AltaMod_estadocivil.Text == "Casado"){
             * new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoPreguntaConyuge().Show();
             * }
             * else {
             * new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoPreguntaHijo().Show();
             * }
             */
        }

        private void btn_ABMAfiliado_Mod_siguiente_Click(object sender, EventArgs e)
        {
            if (txt_ABMpro_nombre.Text != ""
                && txt_ABMpro_apellido.Text != ""
                && txt_ABMpro_NDoc.Text != ""
                && txt_ABMpro_direccion.Text != ""
                && txt_ABMpro_telefono.Text != ""
                && txt_ABMpro_mail.Text != ""
                && cbo_ABMpro_sexo.Text != ""
                //&& txt_ABMAfiliado_AltaMod_planmedico.Text != ""
                ){
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
                MessageBox.Show("Faltan completar datos");
            }
        }

        private void btn_ABMAfiliado_Mod_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btn_ABMAfiliado_AltaMod_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_ABMAfiliado_Alta_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ABMAfiliado_AltaMod_limpiar_Click_1(object sender, EventArgs e)
        {
            txt_ABMpro_nombre.Clear();
            txt_ABMpro_apellido.Clear();
            txt_ABMpro_NDoc.Clear();
            txt_ABMpro_direccion.Clear();
            txt_ABMpro_telefono.Clear();
            txt_ABMpro_mail.Clear();
            //txt_ABMAfiliado_AltaMod_planmedico.Clear();
        }

        private void groupBox_ABMAfiliado_AltaMod_titulo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ABMAfiliado_AltaMod_telefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_ABMAfiliado_Alta_nombre_Click(object sender, EventArgs e)
        {

        }

        private void cbo_ABMAfiliado_AltaMod_estadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
