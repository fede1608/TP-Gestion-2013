using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ClasesDatosTablas;
namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class frmAfiliadoAltaFamiliar : Form
    {
        int opcion_form;
        Afiliado afil;
        public frmAfiliadoAltaFamiliar(int opcion, Afiliado  a)
        {
            InitializeComponent();

            opcion_form = opcion;
            afil = a;
            inicializeTextBox();

        }

        private void inicializeTextBox()
        {
            switch (opcion_form)
            {
                case 2: lbl_ABMAfiliado_AltaFamiliar_texto.Text = "¿Desea registrar al cónyuge?";
                    break;
                case 3: default: 
                    lbl_ABMAfiliado_AltaFamiliar_texto.Text = "¿Desea registrar a un hijo o familiar a cargo?";
                    break;

            }
        }

        private void btn_ABMAfiliado_AltaFamiliar_si_Click(object sender, EventArgs e)
        {

                    new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod(Math.Floor((double)afil.afil_numero / 100), opcion_form).Show();
                    this.Close();
        }

        private void btn_ABMAfiliado_AltaFamiliar_no_Click(object sender, EventArgs e)
        {
            switch (opcion_form)
            {
                case 2: 
                    opcion_form=3;
                    inicializeTextBox();
                    break;
                case 3: default: MessageBox.Show("Se completó el alta de afiliados correctamente");
                    this.Close();
                    break;

            }
        }
    }
}
