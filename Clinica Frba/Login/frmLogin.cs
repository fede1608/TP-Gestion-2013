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
            txtUser.Focus();

        }

        private string pass = "";
        public int var_global_cant_login_fail = 0;
        public Usuario usuario = new Usuario();
        public SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        

        //Cuidado con meter alguna letra del usuario admin en mayuscula, se bugea.

        private void button1_Click(object sender, EventArgs e)
        {
            pass = txtPass.Text.ToSha256();
            
            try
            {
                var result = runner
                    .Single("SELECT * FROM SIGKILL.Usuario WHERE usr_usuario= '{0}' ", txtUser.Text);
                var userFromDb = new Adapter().Transform<Usuario>(result);

                usuario = userFromDb;

                if (userFromDb.usr_password == pass )
                {

                    Filters filter = new Filters();

                    if ((txtUser.Text == userFromDb.usr_usuario) && (pass == userFromDb.usr_password))
                    {
                        
                        filter.AddEqual("rusr_usuario", userFromDb.usr_id.ToString());
                        this.fallas(usuario);
                    }

                    try
                    {
                        var res = runner
                            .Select("SELECT * FROM SIGKILL.rol_usuario", filter);

                        int cantRoles = res.Rows.Count;

                        if (cantRoles > 1)
                        {
                            this.deshabilitarLogeo();
                            string[] miArray = new string[cantRoles];
                            miArray = GetDataRow(res);

                            for (int i = 0; i < cantRoles; i++)
                            {
                                var resultRol = runner.Single("Select * FROM SIGKILL.rol WHERE rol_id = '{0}'", miArray[i]);
                                var userFromDbRol = new Adapter().Transform<Rol>(resultRol);
                                if (userFromDbRol.rol_habilitado == 1)
                                {
                                    cboRol.Items.Add(userFromDbRol.rol_nombre);
                                }
                                else
                                {
                                    MessageBox.Show("¡CUIDADO! Usted tiene el rol '"+userFromDbRol.rol_nombre+"' deshabilitado, intente ingresar al sistema con otro rol.");
                                }
                            }

                        }
                        else
                        {
                            //frm_menuPrincipal formMenu = new frm_menuPrincipal();
                            //this.Hide();
                            //formMenu.Show();
                            MessageBox.Show("Usted no posee Rol de Usuario. Para continuar presione en cancelar");
                            btnAceptar.Enabled = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Usted no tiene asignado ningun Rol");
                    }
 
                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR, verifique su Contraseña");
                        txtPass.Focus();
                        this.fallas(usuario);
                    }
            }
            catch
            {
                MessageBox.Show("ERROR, verifique su Usuario");
              //  this.fallas(usuario);
                txtUser.Text = "";
                txtUser.Focus();
            }


        }


        private void fallas(Usuario usuario)
        {
            var_global_cant_login_fail++;
            txtIntentos.Text = (3 - var_global_cant_login_fail).ToString();

            runner.Update("UPDATE SIGKILL.Usuario SET usr_cant_login_fail = '{0}' WHERE usr_usuario= '{1}' ", var_global_cant_login_fail, usuario.usr_usuario);
            

            if (var_global_cant_login_fail >= 3)
            {
                runner.Update("UPDATE SIGKILL.Usuario SET usr_estado = '{0}' WHERE usr_usuario= '{1}' ", 0, usuario.usr_usuario);
                btnAceptar.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                chkbPass.Enabled = false;
                txtIntentos.Enabled = false;
                lblPass.Enabled = false;
                lblUser.Enabled = false;
                lblIntentos.Enabled = false;
                txtIntentos.Text = (3 - var_global_cant_login_fail).ToString();

            }
        }



        public void btnCancelar_Click(object sender, EventArgs e)
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public string[] GetDataRow(DataTable dt)
        {
            string[] array = new string[dt.Rows.Count];
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                array[index] = dt.Rows[index]["rusr_rol"].ToString();
            }

            return array;
        }

        private void btnAceptarRol_Click(object sender, EventArgs e)
        {
            if (cboRol.Text != "")
            {
                frm_menuPrincipal formMenu = new frm_menuPrincipal();
                var_global_cant_login_fail=0;
                runner.Update("UPDATE SIGKILL.Usuario SET usr_cant_login_fail = '{0}' WHERE usr_usuario= '{1}' ", 0, usuario.usr_usuario);
                this.Hide();
                formMenu.Show();
                bool[] funcionalidades = new bool[12];

                if (cboRol.Text == "Administrador") 
                {
                    funcionalidades[0] = true;
                    funcionalidades[1] = true;
                    funcionalidades[2] = true;
                    funcionalidades[3] = true;
                    funcionalidades[5] = true;
                    funcionalidades[7] = true;
                    funcionalidades[10] = true;
                    funcionalidades[11] = true;
                    formMenu.muestraBotones(funcionalidades);
                    
                }
                if (cboRol.Text == "Profesional")
                {
                    funcionalidades[4] = true;
                    funcionalidades[8] = true;
                    funcionalidades[9] = true;
                    formMenu.muestraBotones(funcionalidades);
                }

                if (cboRol.Text == "Afiliado")
                {
                    funcionalidades[4] = true;
                    funcionalidades[6] = true;
                    funcionalidades[11] = true;
                    formMenu.muestraBotones(funcionalidades);
                }

            }
            else 
            {
                MessageBox.Show("Seleccione un Rol");
            }
        }
        private void btnCancelarRol_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Rol.frmListadoRoles().Show();
        }

        public void deshabilitarLogeo()
        {
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            grbLogin.Enabled = false;
            txtPass.Enabled = false;
            txtUser.Enabled = false;
            chkbPass.Enabled = false;
            lblPass.Enabled = false;
            lblUser.Enabled = false;
            txtIntentos.Enabled = false;
            lblIntentos.Enabled = false;
            this.ClientSize = new System.Drawing.Size(570, 199);
            this.CenterToScreen();


            btnAceptarRol.Visible = true;
            btnCancelarRol.Visible = true;
            grbRol.Visible = true;
            cboRol.Visible = true;
            lblRol.Visible = true;
            
        }

    }
}
