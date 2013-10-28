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

namespace Clinica_Frba.NewFolder10
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            try
            {
                var result = runner
                    .Single("SELECT * FROM SIGKILL.Usuario WHERE usr_usuario= '{0}' ", txtUser.Text);
                var userFromDb = new Adapter().Transform<Usuario>(result);
                txtPass.Text = userFromDb.usr_password;
            }
            catch
            {
                MessageBox.Show("Error de usuario");
            }


        }
    }
}
