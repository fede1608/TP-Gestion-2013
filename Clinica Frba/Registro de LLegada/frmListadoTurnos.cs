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

namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class frmListadoTurnos : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        int type=1;
        public frmListadoTurnos()
        {
            InitializeComponent();
        }
        public frmListadoTurnos(int tipo)
        {
            InitializeComponent();
            type = tipo;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Filters filter = new Filters();
            filter.AddEqualField("trn_afiliado", "afil_numero");
            filter.AddEqualField("trn_profesional", "pro_id");
            filter.AddEqualField("pro_id", "espprof_profesional");
            filter.AddEqualField("espprof_especialidad", "esp_id");
            filter.AddLessThanOrEqual(String.Format("DATEDIFF(HOUR,trn_fecha_hora,'{0}')",Properties.Settings.Default.Date.ToString("yyyy-MM-dd HH:mm")), "0");
            filter.AddOrderBy("trn_fecha_hora", "ASC");
            if (chk_hoy.Checked)
            {
                filter.AddEqual(String.Format("DATEDIFF(DAY,trn_fecha_hora,'{0}')", Properties.Settings.Default.Date.ToString("yyyy-MM-dd")), "0");
            }
            if (txtId.Text.Length > 0)
            {
                filter.AddEqual("trn_id", txtId.Text);
            }
            if (txt_nom_afil.Text.Length > 0)
            {
                filter.AddLike("afil_nombre", txt_nom_afil.Text);
            }
            if (txt_ape_afil.Text.Length > 0)
            {
                filter.AddLike("afil_apellido", txt_ape_afil.Text);
            }
            if (txt_nom_prof.Text.Length > 0)
            {
                filter.AddLike("pro_nombre", txt_nom_prof.Text);
            }
            if (txt_ape_prof.Text.Length > 0)
            {
                filter.AddLike("pro_apellido", txt_ape_prof.Text);
            }
            if (txt_num_afil.Text.Length > 0)
            {
                filter.AddEqual("afil_id", txt_num_afil.Text);
            }
            if (combo_especialidad.SelectedIndex >= 0)
            {
                filter.AddEqual("esp_nombre_especialidad", combo_especialidad.Text);
            }

            try
            {
                var result = runner
                    .Select("SELECT DISTINCT trn_id,trn_fecha_hora,trn_afiliado,afil_Apellido,afil_nombre,trn_profesional,pro_Apellido,pro_nombre FROM SIGKILL.turno,SIGKILL.afiliado,SIGKILL.profesional,SIGKILL.esp_prof,SIGKILL.especialidad", filter);
                dataGridView1.DataSource = result;

            }
            catch
            {
                MessageBox.Show("Error de rol");
            }
        }

        private void frmListadoTurnos_Load(object sender, EventArgs e)
        {
            var esp= new Adapter().TransformMany<Especialidad>(runner.Select("SELECT * FROM SIGKILL.especialidad"));
            foreach (Especialidad r in esp)
            {
                combo_especialidad.Items.Add(r.esp_nombre_especialidad);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex];
            switch (type)
            {
                case 1:
                    Afiliado a = new Adapter().Transform<Afiliado>(runner.Single("SELECT * FROM SIGKILL.afiliado WHERE afil_numero={0}",cell.Cells[2].Value.ToString()));
                    new Clinica_Frba.Registro_de_LLegada.frmRegistroLlegada((long)cell.Cells[0].Value,a).Show();
                    this.Close();
                    break;
                case 2:
                    break;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
