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

namespace Clinica_Frba.Generar_Receta
{
    public partial class frmGenerarReceta : Form
    {
        public Profesional prof;
        public Afiliado afil;
        public Consulta consulta;
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public frmGenerarReceta(Profesional p, Afiliado a, Consulta c)
        {
            prof = p;
            afil = a;
            consulta = c;
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGenerarReceta_Load(object sender, EventArgs e)
        {
            lbl_afiliado.Text = afil.getName();
            lbl_profesional.Text = prof.getName();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            List<string> meds = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                NumericUpDown curNum = (NumericUpDown)this.groupBox2.Controls["num_med" + i.ToString()];
                TextBox curText = (TextBox)this.groupBox2.Controls["txt_med" + i.ToString()];
                if (curNum.Value > 0)
                    meds.Add(curText.Text);
            }
            

            if (meds.GroupBy(n => n).Any(g => g.Count() > 1))
            {
                MessageBox.Show("No se permite recetar 2 veces el mismo medicamento");
                return;
            }

            try
            {
                Bono_Farmacia bono = new Bono_Farmacia();
                try
                {
                    bono = new Adapter().Transform<Bono_Farmacia>(runner.Single("SELECT * FROM SIGKILL.Bono_Farmacia WHERE bonof_id={0}", txt_Bono_Farmacia.Text));
                }
                catch
                {
                    MessageBox.Show("El número de bono ingresado no existe");
                    return;
                }
                if (!bono.esValidoPara(afil))
                {
                    MessageBox.Show("El Bono ingresado no coincide con el Numero de Afiliado ni con de un Familiar asociado");
                    return;
                }
                if (bono.bonof_consumido == 1)
                {
                    MessageBox.Show("El Bono ya fue consumido");
                    return;
                }
                if (bono.bonof_plan_medico != afil.afil_id_plan_medico)
                {
                    MessageBox.Show("El plan médico ha cambiado");
                    return;
                }
                if (bono.vencido())
                {
                    MessageBox.Show("El bono esta vencido");
                    return;
                }
                for (int i = 1; i <= 5; i++)
                {
                    NumericUpDown curNum = (NumericUpDown)this.groupBox2.Controls["num_med" + i.ToString()];
                    TextBox curText = (TextBox)this.groupBox2.Controls["txt_med" + i.ToString()];
                    TextBox curAclaracion = (TextBox)this.groupBox2.Controls["txt_acla" + i.ToString()];
                    if (curNum.Value > 0)
                    {
                        var cantM = runner.Single("SELECT count(*) as cant FROM SIGKILL.medicamento WHERE medic_nombre='{0}'", curText.Text);
                        if ((int)cantM["cant"] == 0)
                        {
                            runner.Insert("INSERT INTO SIGKILL.medicamento(medic_nombre) VALUES ('{0}')", curText.Text);
                        }
                        Medicamento medicam = new Adapter().Transform<Medicamento>(runner.Single("SELECT * FROM SIGKILL.medicamento WHERE medic_nombre='{0}'", curText.Text));
                        runner.Insert("INSERT INTO SIGKILL.medicamento_bono_farmacia(recmed_bono_farmacia,recmed_medicamento,recmed_cantidad,recmed_aclaracion)" +
                            "VALUES ({0},{1},{2},'{3}')", bono.bonof_id.ToString(), medicam.medic_id.ToString(), curNum.Value.ToString(), curAclaracion.Text);
                    }

                }
                runner.Update("UPDATE SIGKILL.Bono_Farmacia SET bonof_consumido=1,bonof_consulta={1}" +
                    "FROM SIGKILL.Bono_Farmacia as bc1 " +
                    "WHERE bc1.bonof_id={0}", bono.bonof_id.ToString(),consulta.cons_id.ToString());
                MessageBox.Show("Receta Agregada Exitosamente");
                MessageBox.Show("Si necesita agregar otra receta, vuelva a hacer clic en Generar Receta");
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







    }
}
