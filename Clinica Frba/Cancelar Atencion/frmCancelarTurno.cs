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
        }
        public frmCancelarTurno(Profesional p)
        {
            prof = p;
            InitializeComponent();
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
