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
    public partial class frmAfiliadoAltaMod : Form
    {
        public frmAfiliadoAltaMod(Boolean alta)
        {    
            InitializeComponent();

            if (alta)
            {
                Text = "Alta";
                btn_ABMAfiliado_Mod_aceptar.Visible = false;
                groupBox_ABMAfiliado_AltaMod_titulo.Text = "Alta afiliado";
            }
            else
            {
                Text = "Modificación";
                groupBox_ABMAfiliado_AltaMod_titulo.Text = "Modificación Afiliado";
                //Estos campos no se pueden modificar
                txt_ABMAfiliado_AltaMod_nombre.Enabled = false;
                txt_ABMAfiliado_AltaMod_apellido.Enabled = false;
                txt_ABMAfiliado_AltaMod_nrodoc.Enabled = false;
                monthCalendar_ABMAfiliado_AltaMod_nacimiento.Enabled = false;
                //Este es el botón siguiente del Alta
                btn_ABMAfiliado_Alta_siguiente.Visible = false;
            }

            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            //Se inicializan las opciones de plan médico
            var pmed = new Adapter().TransformMany<Plan_Medico>(runner.Select("SELECT * FROM SIGKILL.plan_medico"));
            foreach (Plan_Medico r in pmed)
            {
                cbo_ABMAfiliado_AltaMod_planmedico.Items.Add(r.pmed_nombre);
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

        private void btn_ABMAfiliado_Mod_siguiente_Click(object sender, EventArgs e)
        {

        }

        private void btn_ABMAfiliado_Alta_siguiente_Click(object sender, EventArgs e)
        {
            if (txt_ABMAfiliado_AltaMod_nombre.Text != ""
                && txt_ABMAfiliado_AltaMod_apellido.Text != ""
                && txt_ABMAfiliado_AltaMod_nrodoc.Text != ""
                && txt_ABMAfiliado_AltaMod_direccion.Text != ""
                && txt_ABMAfiliado_AltaMod_telefono.Text != ""
                && txt_ABMAfiliado_AltaMod_mail.Text != ""
                && cbo_ABMAfiliado_AltaMod_sexo.Text != ""
                && cbo_ABMAfiliado_AltaMod_estadocivil.Text != ""
                && cbo_ABMAfiliado_AltaMod_planmedico.Text != ""
                ){

                SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

                try
                {
                        runner.Insert("EXEC nuevoAfiliado '{0}', '{1}', {2}, {3},'{4}',{5},'{6}','{7}','{8}','{9}','{10}',{11}",
                        txt_ABMAfiliado_AltaMod_nombre.Text, txt_ABMAfiliado_AltaMod_apellido.Text, 1, int.Parse(txt_ABMAfiliado_AltaMod_nrodoc.Text),
                        txt_ABMAfiliado_AltaMod_direccion.Text, int.Parse(txt_ABMAfiliado_AltaMod_telefono.Text), txt_ABMAfiliado_AltaMod_mail.Text,
                        monthCalendar_ABMAfiliado_AltaMod_nacimiento.SelectionRange.Start.ToShortDateString(), cbo_ABMAfiliado_AltaMod_sexo.Text,
                        cbo_ABMAfiliado_AltaMod_estadocivil.Text, cbo_ABMAfiliado_AltaMod_planmedico.Text, 1);

                    MessageBox.Show("Se ha creado el afiliado base correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            this.Close();
        }

        private void txt_ABMAfiliado_Alta_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ABMAfiliado_AltaMod_limpiar_Click_1(object sender, EventArgs e)
        {
            txt_ABMAfiliado_AltaMod_nombre.Clear();
            txt_ABMAfiliado_AltaMod_apellido.Clear();
            txt_ABMAfiliado_AltaMod_nrodoc.Clear();
            txt_ABMAfiliado_AltaMod_direccion.Clear();
            txt_ABMAfiliado_AltaMod_telefono.Clear();
            txt_ABMAfiliado_AltaMod_mail.Clear();
        }

        private void groupBox_ABMAfiliado_AltaMod_titulo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ABMAfiliado_AltaMod_telefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_ABMAfiliado_AltaMod_check_only_characters_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
