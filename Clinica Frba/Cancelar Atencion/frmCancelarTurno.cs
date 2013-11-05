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
        int tipo = 2;
        public frmCancelarTurno()
        {
            InitializeComponent();
        }
        public frmCancelarTurno(Afiliado a)
        {
            tipo = 2;
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
            tipo = 3;
            prof = p;
            InitializeComponent();
            lbl_profesional.Text = prof.getName();
            lbl_afiliado.Visible = false;
            lbl_af.Visible = false;
            dtp_final.Value = dtp_inicial.Value.AddMinutes(10);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 2:
                    new Clinica_Frba.Registro_de_LLegada.frmListadoTurnos(2, afil).Show();
                    break;
                case 3:
                    new Clinica_Frba.Registro_de_LLegada.frmListadoTurnos(3, prof).Show();
                    break;
            }
            
        }

        private void btn_cancelar_periodo_Click(object sender, EventArgs e)
        {
            if (dtp_inicial.Value > dtp_final.Value)
            {
                MessageBox.Show("Has ingresado un período incorrecto. Verifica los datos ingresados.");
                return;
            }
            if (dtp_inicial.Value < Properties.Settings.Default.Date)
            {
                MessageBox.Show("Has ingresado un periodo anterior al día de hoy.");
                return;
            }
            try
            {
                string value = "Motivo de la cancelacion";
                if (InputBox.Show("Cancelar Turnos por Período", "¿Está seguro que desea Cancelar todos los turnos del período seleccionado? Si es así, ingrese el motivo.", ref value) == DialogResult.OK)
                {
                    prof.cancelarPeriodo(dtp_inicial.Value,dtp_final.Value,4,value);
                    MessageBox.Show("Se ha cancelado correctamente");
                }else
                    MessageBox.Show("No se ha cancelado los turnos");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
}
