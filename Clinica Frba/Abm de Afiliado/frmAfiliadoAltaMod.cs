﻿using System;
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
        public frmAfiliadoAltaMod()
        {    
            InitializeComponent();

            //Dependiendo de dónde lo llamen
            //tiene que decidir qué componentes visualiza
            //Por default es la primer Alta
            Boolean alta = true;
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
                //&& txt_ABMAfiliado_AltaMod_apellido.Text != ""
                //&& txt_ABMAfiliado_AltaMod_nrodoc.Text != ""
                //&& txt_ABMAfiliado_AltaMod_direccion.Text != ""
                //&& txt_ABMAfiliado_AltaMod_telefono.Text != ""
                //&& txt_ABMAfiliado_AltaMod_mail.Text != ""
                //&& cbo_ABMAfiliado_AltaMod_sexo.Text != ""
                //&& cbo_ABMAfiliado_AltaMod_estadocivil.Text != ""
                //&& txt_ABMAfiliado_AltaMod_planmedico.Text != ""
                ){

                SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

                try
                {
                    //var user_check = runner.Single("select COUNT(*) as cant from GD2C2013.SIGKILL.usuario where usr_usuario = '{0}'", usr_usuario);

                    runner.Insert("EXEC nuevoAfiliado '{0}', '{1}', {2}, {3},'{4}',{5},'{6}','{7}','{8}','{9}',{10}",
                        txt_ABMAfiliado_AltaMod_nombre.Text, txt_ABMAfiliado_AltaMod_apellido.Text, 1, int.Parse(txt_ABMAfiliado_AltaMod_nrodoc.Text),
                        txt_ABMAfiliado_AltaMod_direccion.Text, int.Parse(txt_ABMAfiliado_AltaMod_telefono.Text), txt_ABMAfiliado_AltaMod_mail.Text,
                        monthCalendar_ABMAfiliado_AltaMod_nacimiento.SelectionRange.Start.ToShortDateString(), cbo_ABMAfiliado_AltaMod_sexo.Text,
                        cbo_ABMAfiliado_AltaMod_estadocivil.Text, 555558);

                    MessageBox.Show("Ok!");

                    // En caso que no exista un usuario, lo crea
                    // usr_usuario = 'u'+nroDni
                    // pass = 'default' (SHA256)
                    /*
                    if ((int)user_check["cant"] == 0)
                    {
                        MessageBox.Show("La cantidad es 0");
                        runner.Insert("INSERT INTO GD2C2013.SIGKILL.usuario (usr_usuario, usr_password)" +
                        "VALUES ( '{0}', '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f')", usr_usuario);
                    }

                    var nro_afiliado = runner.Single("select SIGKILL.getNextNumeroAfiliado()*100+1");
                    MessageBox.Show("Prox num afiliado: " + nro_afiliado[0]);
                    int nro_doc = int.Parse(txt_ABMAfiliado_AltaMod_nrodoc.Text);
                    MessageBox.Show("Nro doc: " + nro_doc);
                    String fecha_nacimiento = monthCalendar_ABMAfiliado_AltaMod_nacimiento.SelectionRange.Start.ToShortDateString();
                    MessageBox.Show("Fecha nacimiento: " + fecha_nacimiento);
                    var estado_civil = runner.Single("select estciv_id from GD2C2013.SIGKILL.estado_civil where estciv_descripcion = '{0}'", cbo_ABMAfiliado_AltaMod_estadocivil.Text);
                    MessageBox.Show("Estado civil Id: " + estado_civil[0]);
                     * */

                    /*
                    runner.Insert("INSERT into GD2C2013.SIGKILL.afiliado (afil_numero, afil_usuario, afil_nombre, afil_apellido, afil_tipo_doc, afil_dni, afil_direccion, afil_telefono, afil_mail, afil_nacimiento, afil_sexo, afil_estado_civil, afil_id_plan_medico)" +
                    "VALUES ( {0},'{1}', '{2}', '{3}', '{4}', {5}, '{6}', {7}, '{8}', '{9}', '{10}', '{11}', {12})", 50000000, usr_usuario, txt_ABMAfiliado_AltaMod_nombre.Text, txt_ABMAfiliado_AltaMod_apellido.Text, 1,
                    nro_doc, txt_ABMAfiliado_AltaMod_direccion.Text, txt_ABMAfiliado_AltaMod_telefono.Text, txt_ABMAfiliado_AltaMod_mail.Text, fecha_nacimiento,
                    cbo_ABMAfiliado_AltaMod_sexo.Text, estado_civil, txt_ABMAfiliado_AltaMod_planmedico.Text);
                    
                    runner.Insert("INSERT into GD2C2013.SIGKILL.afiliado (afil_numero, afil_usuario, afil_nombre, afil_apellido, afil_dni, afil_direccion)" +
                        "VALUES ({0},'{1}', '{2}', '{3}', {4}, '{5}')", 800000, usr_usuario, nombre, apellido, nro_doc, direccion);
                    MessageBox.Show("5");
                    **/

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                    /*
                    String fecha = monthCalendar_ABMAfiliado_AltaMod_nacimiento.SelectionRange.Start.ToShortDateString();
                    txt_ABMAfiliado_AltaMod_nombre.CharacterCasing = CharacterCasing.Upper;
                    int dni = int.Parse(txt_ABMAfiliado_AltaMod_nrodoc.Text);
                    int telefono = int.Parse(txt_ABMAfiliado_AltaMod_telefono.Text);
                    string nombre_usuario = "u" + Convert.ToString(txt_ABMAfiliado_AltaMod_nrodoc.Text);
                    
                        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
                        try
                        {
                            var result = runner
                                .Single("INSERT INTO SIGKILL.Usuario WHERE usr_usuario= '{0}' ", txtUser.Text);
                     * var result = runner
                                .Single("INSERT INTO SIGKILL.Usuario () usr_usuario= '{0}' ", txtUser.Text);
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
            txt_ABMAfiliado_AltaMod_nombre.Clear();
            txt_ABMAfiliado_AltaMod_apellido.Clear();
            txt_ABMAfiliado_AltaMod_nrodoc.Clear();
            txt_ABMAfiliado_AltaMod_direccion.Clear();
            txt_ABMAfiliado_AltaMod_telefono.Clear();
            txt_ABMAfiliado_AltaMod_mail.Clear();
            txt_ABMAfiliado_AltaMod_planmedico.Clear();
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
