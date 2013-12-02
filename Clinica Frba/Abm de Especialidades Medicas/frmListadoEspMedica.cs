using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Sql;

namespace Clinica_Frba.Abm_de_Especialidades_Medicas
{
    public partial class frmListadoEspMedica : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public frmListadoEspMedica()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = runner.Select("SELECT * FROM SIGKILL.especialidad WHERE esp_id>0");
        }
    }
}
