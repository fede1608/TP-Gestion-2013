using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clinica_Frba.ClasesDatosTablas;
using Clinica_Frba.Sql;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class frmRolAltaMod : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public frmRolAltaMod()
        {
            InitializeComponent();
            loadAlta();
        }
        public frmRolAltaMod(Rol rol)
        {

            InitializeComponent();
            loadMod(rol);
        }

        private void loadMod(Rol rol)
        {
            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.funcionalidad");
                var funcFromDb = new Adapter().TransformMany<Funcionalidad>(result);
                var result2 = runner
                    .Select("SELECT func_id,func_descripcion FROM SIGKILL.funcionalidad inner join SIGKILL.func_rol on(func_id=frol_funcionalidad) Where frol_rol={0}",rol.rol_id);
                var lista = new Adapter().TransformMany<Funcionalidad>(result2);
                txtNombre.Text = rol.rol_nombre;
                chk_habilitado.Checked = rol.rol_habilitado==1;
                foreach (var func in funcFromDb)
                {
                    if (lista.Any(f=> f.func_id==func.func_id))
                        checkedListBox1.Items.Add(func.func_descripcion, true);
                    else 
                        checkedListBox1.Items.Add(func.func_descripcion);
                }

            }
            catch
            {
                MessageBox.Show("Error de funcionalidad");
            }
        }

        private void loadAlta()
        {
            
            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.funcionalidad");
                var funcFromDb = new Adapter().TransformMany<Funcionalidad>(result);
                foreach (var func in funcFromDb)
                {
                    checkedListBox1.Items.Add(func.func_descripcion);
                }

            }
            catch
            {
                MessageBox.Show("Error de funcionalidad");
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_alta_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("No ingresaste el nombre");
                return;
            }
            int hab=0;
            if (chk_habilitado.Checked)
                hab=1;

            runner.Insert("INSERT INTO SIGKILL.rol(rol_nombre,rol_habilitado) VALUES ('{0}',{1})", txtNombre.Text, hab.ToString());
            var res=runner.Single("SELECT * FROM SIGKILL.rol WHERE rol_nombre='{0}'", txtNombre.Text);
            Rol newrol = new Adapter().Transform<Rol>(res);
            foreach(var f in checkedListBox1.CheckedItems){
                runner.Insert("INSERT INTO SIGKILL.func_rol(frol_rol,frol_funcionalidad) VALUES ({0},{1})",newrol.rol_id.ToString(),(checkedListBox1.CheckedItems.IndexOf(f)+1).ToString());
            }
            MessageBox.Show("Rol ingresado Correctamente");
                
        }
    }
}
