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

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class frmAfiliadoListado : Form
    {
        public frmAfiliadoListado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            var pmed = new Adapter().TransformMany<Plan_Medico>(runner.Select("SELECT * FROM SIGKILL.plan_medico"));
            foreach (Plan_Medico r in pmed)
            {
                cbo_Listado_planmedico.Items.Add(r.pmed_nombre);
            }
            cbo_Listado_planmedico.DisplayMember = "pmed_nombre";
        }

        private void btn_ABMAfiliado_Listado_Buscar_Click(object sender, EventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            Filters filter = new Filters();
            if (txt_Listado_nroafiliado.Text.Length > 0)
            {
                filter.AddEqual("afil_numero", txt_Listado_nroafiliado.Text);
            }
            if (txt_Listado_nombre.Text.Length > 0)
            {
                filter.AddEqual("afil_nombre", txt_Listado_nombre.Text);
            }
            if (txt_Listado_apellido.Text.Length > 0)
            {
                filter.AddEqual("afil_apellido", txt_Listado_apellido.Text);
            }
            if (txt_Listado_nrodoc.Text.Length > 0)
            {
                filter.AddEqual("afil_dni", txt_Listado_nrodoc.Text);
            }
            if (cbo_Listado_planmedico.Text.Length > 0)
            {
                //TODO: arreglar
                Plan_Medico plan_med = (Plan_Medico)cbo_Listado_planmedico.SelectedValue;
                filter.AddEqual("afil_id_plan_medico", plan_med.pmed_id.ToString());
            }

            try
            {
                var result = runner
                    .Select("SELECT * FROM SIGKILL.afiliado", filter);
                dbgrb_ABMAfiliado_Listado_vista.DataSource = result;

            }
            catch
            {
                MessageBox.Show("Error de rol");
            }
        }

        private void btn_Listado_limpiar_Click(object sender, EventArgs e)
        {
            txt_Listado_apellido.Clear();
            txt_Listado_nombre.Clear();
            txt_Listado_nroafiliado.Clear();
            txt_Listado_nrodoc.Clear();
        }

        private void dbgrb_ABMAfiliado_Listado_vista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

            var cell = dbgrb_ABMAfiliado_Listado_vista.Rows[e.RowIndex];
            
            var res = runner.Single("SELECT * FROM SIGKILL.afiliado WHERE afil_numero={0}", cell.Cells[0].Value.ToString());
            Afiliado afil = new Adapter().Transform<Afiliado>(res);
            new frmAfiliadoAltaMod(false, (long)cell.Cells[0].Value, false).Show();
        }
    }
}
