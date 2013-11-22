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
        public Plan_Medico pmed;
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
            pmed = new Adapter().Transform<Plan_Medico>(res);
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
            
        }

        private void txtConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtConsulta.Text == "") txtConsulta.Text = "0";
            if (txtFarmacia.Text == "") txtFarmacia.Text = "0";
            txtTotConsulta.Text = toMoney(pmed.pmed_precio_bono_consulta * Convert.ToDouble(txtConsulta.Text));
            txtTotal.Text=toMoney(pmed.pmed_precio_bono_consulta * Convert.ToDouble(txtConsulta.Text)+(pmed.pmed_precio_bono_farmacia * Convert.ToDouble(txtFarmacia.Text)));
        }

        private void txtFarmacia_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFarmacia.Text == "") txtFarmacia.Text = "0";
            if (txtConsulta.Text == "") txtConsulta.Text = "0";
            txtTotFarmacia.Text = toMoney(pmed.pmed_precio_bono_farmacia * Convert.ToDouble(txtFarmacia.Text));
            txtTotal.Text=toMoney((pmed.pmed_precio_bono_consulta * Convert.ToDouble(txtConsulta.Text))+(pmed.pmed_precio_bono_farmacia * Convert.ToDouble(txtFarmacia.Text)));
        
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if ((txtConsulta.Text != "" && txtConsulta.Text != "0") && (txtFarmacia.Text != "" && txtFarmacia.Text != "0"))
            {
                if (txtConsulta.Text == "") txtConsulta.Text = "0";
                if (txtFarmacia.Text == "") txtFarmacia.Text = "0";
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de comprar " + txtConsulta.Text + " Bono/s de Consulta y " + txtFarmacia.Text + " Bono/s de Farmacia?", "Comprar Bonos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    double total = ((pmed.pmed_precio_bono_consulta * Convert.ToDouble(txtConsulta.Text)) + (pmed.pmed_precio_bono_farmacia * Convert.ToDouble(txtFarmacia.Text)));
                    runner.Insert("INSERT INTO SIGKILL.compra_bono (compra_afiliado,compra_fecha_de_compra,compra_cant_bono_consulta,compra_cant_bono_farmacia,compra_total_abonado)" +
                        "VALUES ({0},GETDATE(),{1},{2},{3})", afil.afil_numero.ToString(), txtConsulta.Text, txtFarmacia.Text, total.ToString());

                    var res = runner.Single("SELECT MAX(bonoc_id)+1 as next FROM SIGKILL.bono_consulta");

                    long id = (long)res["next"];
                    long i;
                    string num_bonosc = "";
                    for (i = id; i < id + Convert.ToInt64(txtConsulta.Text); i++)
                    {
                        num_bonosc += i.ToString() + " ";
                        runner.Insert("INSERT INTO SIGKILL.bono_consulta(bonoc_id,bonoc_afiliado,bonoc_fecha_compra,bonoc_plan_medico,bonoc_precio)" +
                            "VALUES ({0},{1},GETDATE(),{2},{3})", i, afil.afil_numero, afil.afil_id_plan_medico, pmed.pmed_precio_bono_consulta);

                    }

                    res = runner.Single("SELECT MAX(bonof_id)+1 as next FROM SIGKILL.bono_farmacia");
                    long id2 = (long)res["next"];
                    string num_bonosf = "";
                    for (i = id2; i < id2 + Convert.ToInt64(txtFarmacia.Text); i++)
                    {
                        num_bonosf += i.ToString() + " ";
                        runner.Insert("INSERT INTO SIGKILL.bono_farmacia(bonof_id,bonof_afiliado,bonof_fecha_compra,bonof_plan_medico,bonof_precio)" +
                            "VALUES ({0},{1},GETDATE(),{2},{3})", i, afil.afil_numero, afil.afil_id_plan_medico, pmed.pmed_precio_bono_farmacia);

                    }
                    MessageBox.Show("Se ha comprado correctamente. Los Numeros de bonos de consulta son: " + num_bonosc + " y los de Farmacia: " + num_bonosf);

                }
            }
            else
            {
                MessageBox.Show("No se pueden comprar 0 bonos consulta y 0 bonos farmacia");
            }
        }
    }
}
