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

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class frmListadoRoles : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public frmListadoRoles()
        {
            InitializeComponent();

        }

        private void frmListadoRoles_Load(object sender, EventArgs e)
        {

            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.rol");
                var rolFromDb = new Adapter().TransformMany<Rol>(result);
                foreach (var rol in rolFromDb)
                {
                    comboBox1.Items.Add(rol.rol_nombre);
                }

            }
            catch
            {
                MessageBox.Show("Error de rol");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filters filter = new Filters();
            if (txtId.Text.Length>0){
                filter.AddEqual("rol_id", txtId.Text);
            }
            
            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.rol",filter);
                dataGridView1.DataSource = result;

            }
            catch
            {
                MessageBox.Show("Error de rol");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex];
            //MessageBox.Show("Se clickeo " + cell.Cells[0].Value.ToString());
            var res = runner.Single("SELECT * FROM SIGKILL.rol WHERE rol_id={0}", cell.Cells[0].Value.ToString());
            Rol rol = new Adapter().Transform<Rol>(res);
            new frmRolAltaMod(rol).Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmRolAltaMod().Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
