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
    public partial class frmRegistroLlegada : Form
    {
        public long turno;
        public Afiliado afil;
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public frmRegistroLlegada(long numturno, Afiliado a)
        {
            InitializeComponent();
            turno = numturno;
            afil = a;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroLlegada_Load(object sender, EventArgs e)
        {

            lbl_afiliado.Text = afil.getName();
            lbl_turno.Text = turno.ToString();
            lbl_hora_llegada.Text = Properties.Settings.Default.Date.ToString("HH:mm");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Bono_Consulta bono = new Bono_Consulta();
                try
                {
                    bono = new Adapter().Transform<Bono_Consulta>(runner.Single("SELECT * FROM SIGKILL.bono_consulta WHERE bonoc_id={0}", txt_bono_consulta.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El número de bono ingresado no existe");
                    return;
                }

                if (afil.getNumeroAfiliadoPrincipal() != afil.numeroAfiliadoPrincipal(Convert.ToInt64(bono.bonoc_afiliado)))
                {
                    MessageBox.Show("El Bono ingresado no coincide con el Numero de Afiliado ni con de un Familiar asociado");
                    return;
                }
                if (bono.bonoc_consumido == 1)
                {
                    MessageBox.Show("El Bono ya fue consumido");
                    return;
                }

                runner.Insert("INSERT INTO SIGKILL.consulta(cons_turno,cons_bono_consulta,cons_fecha_hora_llegada)" +
                    "VALUES ({0},{1},'{2}')", lbl_turno.Text, txt_bono_consulta.Text, lbl_hora_llegada.Text);
                runner.Update("UPDATE SIGKILL.bono_consulta SET bonoc_consumido=1,bonoc_nro_consulta_individual=(SELECT COUNT(*) FROM SIGKILL.bono_consulta as bc2 WHERE bc2.bonoc_afiliado=bc1.bonoc_afiliado AND bc2.bonoc_fecha_compra<=bc1.bonoc_fecha_compra AND bc2.bonoc_consumido=1 )" +
                    " from SIGKILL.bono_consulta as bc1 " +
                    "WHERE bc1.bonoc_id={0}", bono.bonoc_id);
                MessageBox.Show("Llegada registrada Exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_bono_consulta_KeyPress(object sender, KeyPressEventArgs e)
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

 
    }
}
