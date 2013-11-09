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

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class frmResultadosEstadisticos : Form
    {
        public Estadistica estadistica;
        public List<String> meses = new List<String>();
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public frmResultadosEstadisticos(Estadistica est)
        {
            estadistica = est;
            InitializeComponent();
        }

        private void frmResultadosEstadisticos_Load(object sender, EventArgs e)
        {
            if (estadistica.semestre == 1)
            {
                combo_fecha.Items.Add("Total Semestre");
                meses.Add("1,2,3,4,5,6");
                combo_fecha.Items.Add("Enero");
                meses.Add("1");
                combo_fecha.Items.Add("Febrero");
                meses.Add("2");
                combo_fecha.Items.Add("Marzo");
                meses.Add("3");
                combo_fecha.Items.Add("Abril");
                meses.Add("4");
                combo_fecha.Items.Add("Mayo");
                meses.Add("5");
                combo_fecha.Items.Add("Junio");
                meses.Add("6");

            }
            else
            {
                combo_fecha.Items.Add("Total Semestre");
                meses.Add("7,8,9,10,11,12");
                combo_fecha.Items.Add("Julio");
                meses.Add("7");
                combo_fecha.Items.Add("Agosto");
                meses.Add("8");
                combo_fecha.Items.Add("Septiembre");
                meses.Add("9");
                combo_fecha.Items.Add("Octubre");
                meses.Add("10");
                combo_fecha.Items.Add("Noviembre");
                meses.Add("11");
                combo_fecha.Items.Add("Diciembre");
                meses.Add("12");
            }
            groupBox1.Text = estadistica.name;
        }

        private void combo_fecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res=runner.Select(estadistica.consulta, meses[combo_fecha.SelectedIndex],Properties.Settings.Default.Date.Year.ToString());
            dataGridView1.DataSource = res;

        }



    }
}
