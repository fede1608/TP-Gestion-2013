using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class frmCancelarTurno : Form
    {
        public frmCancelarTurno()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
