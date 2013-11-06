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

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class frmListadoConsultas : Form
    {
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public Profesional prof;
        public frmListadoConsultas(Profesional p)
        {
            prof = p;
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Filters filter = new Filters();
            filter.AddEqualField("cons_turno", "trn_id");
            filter.AddEqualField("trn_afiliado", "afil_numero");
            filter.AddEqual("trn_profesional", prof.pro_id.ToString());
            filter.AddEqualField("trn_profesional", "pro_id");
            filter.AddIsNull("cons_fecha_hora_atencion");
            filter.AddEqual(String.Format("DATEDIFF(DAY,trn_fecha_hora,'{0}')", Properties.Settings.Default.Date.ToString("yyyy-MM-dd")), "0");
            filter.AddLessThanOrEqual(String.Format("DATEDIFF(HOUR,trn_fecha_hora,'{0}')", Properties.Settings.Default.Date.ToString("yyyy-MM-dd HH:mm")), "0");
            filter.AddOrderBy("trn_fecha_hora", "ASC");
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
            if (txt_num_afil.Text.Length > 0)
            {
                filter.AddEqual("afil_numero", txt_num_afil.Text);
            }
            try
            {
                var result = runner
                    .Select("SELECT DISTINCT cons_id,trn_id,trn_fecha_hora,trn_afiliado,afil_Apellido,afil_nombre FROM SIGKILL.turno,SIGKILL.afiliado,SIGKILL.profesional,SIGKILL.consulta", filter);
                dataGridView1.DataSource = result;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dataGridView1.Rows[e.RowIndex];
            new Clinica_Frba.Registro_Resultado_Atencion.frmRegistroAtencion(Afiliado.newFromId((long)cell.Cells[3].Value), prof, Consulta.newFromId((long)cell.Cells[0].Value)).Show();
            this.Close();
        }

        private void frmListadoConsultas_Load(object sender, EventArgs e)
        {
            lbl_profesional.Text = prof.getName();
        }
    }
}
