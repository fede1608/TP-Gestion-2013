using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Sql;
using Clinica_Frba.ClasesDatosTablas;
namespace Clinica_Frba.Registro_de_Usuario
{
    public partial class frmAgregarUsuario : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text == "" || txt_pass.Text == "" || txt_pass2.Text == "")
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }
                if (txt_pass.Text != txt_pass2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                }
                runner.Insert("INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)" +
                    "VALUES ('{0}','{1}')", txt_user.Text, toSha256.ToSha256(txt_pass.Text));
                MessageBox.Show("Usuario Agregado ExitosaMente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
