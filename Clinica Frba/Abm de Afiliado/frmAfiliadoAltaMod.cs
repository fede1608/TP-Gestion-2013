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

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Form1 : Form
    {
        public Form1()
        {    
            InitializeComponent();

            //Dependiendo de dónde lo llamen
            //tiene que decidir qué componentes visualiza
            //Por default es la primer Alta
            Boolean alta = true;
            if (alta)
            {
                btn_ABMAfiliado_Mod_aceptar.Visible = false;
                lbl_ABMAfiliado_Alta_titulo.Text = "Alta Afiliado";
            }
            else
            {
                lbl_ABMAfiliado_Alta_titulo.Text = "Modificación Afiliado";
                //Estos campos no se pueden modificar
                txt_ABMAfiliado_AltaMod_nombre.Visible = false;
                txt_ABMAfiliado_AltaMod_apellido.Visible = false;
                txt_ABMAfiliado_AltaMod_nrodoc.Visible = false;
                upd_ABMAfiliado_AltaMod_dia.Visible = false;
                upd_ABMAfiliado_AltaMod_mes.Visible = false;
                txt_ABMAfiliado_AltaMod_anio.Visible = false;
                //Este es el botón siguiente del Alta
                btn_ABMAfiliado_Alta_siguiente.Visible = false;
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

        private void btn_ABMAfiliado_AltaMod_limpiar_Click(object sender, EventArgs e)
        {
            //Falta resetear dia, mes, sexo y estado civil
            txt_ABMAfiliado_AltaMod_nombre.Clear();
            txt_ABMAfiliado_AltaMod_apellido.Clear();
            txt_ABMAfiliado_AltaMod_nrodoc.Clear();
            txt_ABMAfiliado_AltaMod_direccion.Clear();
            txt_ABMAfiliado_AltaMod_telefono.Clear();
            txt_ABMAfiliado_AltaMod_mail.Clear();
            txt_ABMAfiliado_AltaMod_anio.Clear();
            txt_ABMAfiliado_AltaMod_planmedico.Clear();
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
            if (txt_ABMAfiliado_AltaMod_nombre.Text != ""
                && txt_ABMAfiliado_AltaMod_apellido.Text != ""
                && txt_ABMAfiliado_AltaMod_nrodoc.Text != ""
                && txt_ABMAfiliado_AltaMod_direccion.Text != ""
                && txt_ABMAfiliado_AltaMod_telefono.Text != ""
                && txt_ABMAfiliado_AltaMod_mail.Text != ""
                && txt_ABMAfiliado_AltaMod_anio.Text != ""
                && cbo_ABMAfiliado_AltaMod_sexo.Text != ""
                && cbo_ABMAfiliado_AltaMod_estadocivil.Text != ""
                && txt_ABMAfiliado_AltaMod_planmedico.Text != ""
                ){
                /*
                    SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
                    //pass = txtPass.Text.ToSha256();
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

        private void btn_ABMAfiliado_AltaMod_atras_Click(object sender, EventArgs e)
        {
            //En el caso que jamás se cierre el menú principal
            //this.Close();
        }

        private void txt_ABMAfiliado_Alta_mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
