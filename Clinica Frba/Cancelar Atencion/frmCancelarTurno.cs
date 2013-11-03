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

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class frmCancelarTurno : Form
    {
        Afiliado afil;//tipo 2
        Profesional prof;//tipo 3

        public frmCancelarTurno()
        {
            InitializeComponent();
        }
        public frmCancelarTurno(Afiliado a)
        {
            afil = a;
            InitializeComponent();
            lbl_prf.Visible = false;
            lbl_profesional.Visible = false;
            lbl_afiliado.Text = afil.getName();
            btn_cancelar_periodo.Visible = false;
            dtp_inicial.Visible = false;
            dtp_final.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }
        public frmCancelarTurno(Profesional p)
        {
            prof = p;
            InitializeComponent();
            lbl_profesional.Text = prof.getName();
            lbl_afiliado.Visible = false;
            lbl_af.Visible = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Registro_de_LLegada.frmListadoTurnos(2, afil).Show();
        }




    }
}
