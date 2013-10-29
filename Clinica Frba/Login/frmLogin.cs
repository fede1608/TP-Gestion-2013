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
        public int var_global_cant_login_fail = 0;
        public Usuario usuario = new Usuario();
        

        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            
            pass = txtPass.Text.ToSha256();
            try
            {
                var result = runner
                    .Single("SELECT * FROM SIGKILL.Usuario WHERE usr_usuario= '{0}' ", txtUser.Text);
                var userFromDb = new Adapter().Transform<Usuario>(result);
                
                //txtPass.Text = userFromDb.usr_password;
                if (userFromDb.EstaBloqueado==1)
                    throw new ApplicationException("El usuario se encuentra bloqueado.");

                  usuario = userFromDb;

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
                    this.fallas(usuario);
                }
            }
            catch
            {
                MessageBox.Show("ERROR, verifique su Usuario");
                this.fallas(usuario);
                txtUser.Text = "";
                //txtPass.Text = "";
                txtUser.Focus();
            }
        }


        private void fallas(Usuario usuario)
        {
            //usuario.usr_cant_login_fail++;
            //usuario.usr_estado = usuario.EstaBloqueado;
           
            //textBox1.Text = usuario.usr_estado.ToString();
            var_global_cant_login_fail++;
            textBox1.Text = (var_global_cant_login_fail).ToString();
            
            if (var_global_cant_login_fail>=3)
            {
                btnAceptar.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                checkBox1.Enabled = false;
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
