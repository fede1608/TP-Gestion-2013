using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class frmAfiliadoAltaFamiliar : Form
    {
        int opcion_form;

        public frmAfiliadoAltaFamiliar(int opcion)
        {
            InitializeComponent();

            opcion_form = opcion;

            switch (opcion_form)
            {
                case 1: lbl_ABMAfiliado_AltaFamiliar_texto.Text = "¿Desea registrar al cónyuge?";
                    break;
                case 2: lbl_ABMAfiliado_AltaFamiliar_texto.Text = "¿Desea registrar a un hijo?";
                    break;
                case 3: lbl_ABMAfiliado_AltaFamiliar_texto.Text = "¿Desea registrar a un familiar a cargo?";
                    break;

            }

        }

        private void btn_ABMAfiliado_AltaFamiliar_si_Click(object sender, EventArgs e)
        {
            switch (opcion_form)
            {
                case 1: 
                    new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod(true, 0, false).Show();
                    break;
                case 2:
                    new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod(true, 0, false).Show();
                    break;
                case 3:
                    new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaMod(true, 0, false).Show();
                    break;

            }
        }

        private void btn_ABMAfiliado_AltaFamiliar_no_Click(object sender, EventArgs e)
        {
            switch (opcion_form)
            {
                case 1: 
                    new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaFamiliar(2).Show();
                    this.Close();
                    break;
                case 2: new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoAltaFamiliar(3).Show();
                    this.Close();
                    break;
                case 3: MessageBox.Show("Se completó el alta de afiliados correctamente");
                    this.Close();
                    break;

            }
        }
    }
}
