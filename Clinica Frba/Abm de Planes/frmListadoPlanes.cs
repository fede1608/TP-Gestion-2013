using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Sql;

namespace Clinica_Frba.Abm_de_Planes
{
    public partial class frmListadoPlanes : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public frmListadoPlanes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = runner.Select("SELECT * FROM SIGKILL.plan_medico");
        }
    }
}
