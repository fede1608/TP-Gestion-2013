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

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class frmCompraBonos : Form
    {
        public Usuario usuario;
        public Afiliado afil;
        public SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public frmCompraBonos(Usuario user)
        {
            InitializeComponent();
            usuario = user;
            afil = user.getAfiliado();
            inicializarPrecios();
        }

        private void inicializarPrecios()
        {
            var res = runner.Single("SELECT * FROM SIGKILL.plan_medico WHERE pmed_id={0}", afil.afil_id_plan_medico.ToString());
            Plan_Medico pmed = new Adapter().Transform<Plan_Medico>(res);
            lbl_precio_consulta.Text = toMoney(pmed.pmed_precio_bono_consulta);
            lbl_precio_farmacia.Text = toMoney(pmed.pmed_precio_bono_farmacia);
        }

        private string toMoney(double p)
        {
            return "$" + p.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtConsulta.Text=="") txtConsulta.Text="0";
            txtTotConsulta.Text = toMoney(Convert.ToDouble(lbl_precio_consulta.Text) * Convert.ToDouble(txtConsulta.Text));
        }
    }
}
