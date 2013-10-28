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

namespace Clinica_Frba.NewFolder10
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string pass = "";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            pass = txtPass.Text.ToSha256();
            try
            {
                var result = runner
                    .Single("SELECT * FROM SIGKILL.Usuario WHERE usr_usuario= '{0}' ", txtUser.Text);
                var userFromDb = new Adapter().Transform<Usuario>(result);
                //txtPass.Text = userFromDb.usr_password;
                if (userFromDb.usr_password == pass)
                {
                    frm_menuPrincipal formMenu = new frm_menuPrincipal();
                    this.Hide();
                    formMenu.Show();
                }
                else
                {
                    MessageBox.Show("ERROR, verifique su Contraseña");
                    //txtPass.Text = userFromDb.usr_password.ToSha256();
                   // txtPass.Text = "";
                    txtPass.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error de Usuario");
                txtUser.Text = "";
                txtPass.Text = "";
                txtPass.Focus();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmListadoRoles().Show();
            
        }

        int b = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (b == 0)
            {
                txtPass.UseSystemPasswordChar = false;
                b++;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                b = 0;
            }
        }
    }
}
