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
    public partial class frmRegistroAtencion : Form
    {
        public Afiliado afil;
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public Profesional prof;
        public Consulta consulta;

        public frmRegistroAtencion(Afiliado a,Profesional p, Consulta c)
        {
            afil = a;
            prof = p;
            consulta = c;
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                runner.Update("UPDATE SIGKILL.consulta SET cons_fecha_hora_atencion='{0}',cons_sintomas='{1}',cons_diagnostico='{2}' WHERE cons_id={3}",
                    lbl_hora_atencion.Text, txt_sintomas.Text, txt_diagnostico.Text, consulta.cons_id.ToString());
                MessageBox.Show("Se ha registrado la Atención Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroAtencion_Load(object sender, EventArgs e)
        {
            lbl_afiliado.Text = afil.getName();
            lbl_consulta.Text = consulta.cons_id.ToString();
            lbl_hora_atencion.Text = Properties.Settings.Default.Date.ToString("HH:mm");
            lbl_profesional.Text = prof.getName();
            lbl_turno.Text = consulta.cons_turno.ToString();
        }
    }
}
