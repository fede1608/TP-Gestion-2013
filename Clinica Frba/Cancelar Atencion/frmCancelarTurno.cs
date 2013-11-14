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
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        Afiliado afil;//tipo 2
        Profesional prof;//tipo 3
        Usuario user;//tipo 1 Admin
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
            lbl_admin.Visible = false;
            btn_afiliado.Visible = false;
            btn_profesional.Visible = false;
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
            lbl_admin.Visible = false;
            btn_afiliado.Visible = false;
            btn_profesional.Visible = false;
        }

        public frmCancelarTurno(Usuario u)
        {
            tipo = 1;
            user = u;
            InitializeComponent();
            lbl_prf.Visible = false;
            lbl_profesional.Visible = false;
            lbl_afiliado.Visible = false;
            lbl_af.Visible = false;
            button1.Visible = false;
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
                    if (tipo == 2)
                        cancelarPeriodo(dtp_inicial.Value, dtp_final.Value, 4, value, prof);
                    else
                        cancelarPeriodo(dtp_inicial.Value, dtp_final.Value, 6, value);
                    MessageBox.Show("Se ha cancelado correctamente");
                }else
                    MessageBox.Show("No se ha cancelado los turnos");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void cancelarPeriodo(DateTime inicio, DateTime fin, int tipo, string razon,Profesional prof)
        {
            fin = fin.AddDays(1);
            runner.Insert("INSERT INTO SIGKILL.cancelacion_atencion_medica(cam_profesional,cam_nro_afiliado,cam_tipo_cancelacion,cam_motivo,cam_fecha_turno,cam_fecha_cancelacion)" +
            "(SELECT trn_profesional,trn_afiliado,{3},'{4}',trn_fecha_hora,'{5}' FROM SIGKILL.turno WHERE trn_profesional={0} AND trn_fecha_hora between '{1}' and '{2}')", prof.pro_id.ToString(), inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"), tipo.ToString(), razon, Properties.Settings.Default.Date.ToString("yyyy-MM-dd"));
            runner.Delete("DELETE FROM SIGKILL.turno WHERE trn_profesional={0} AND trn_fecha_hora between '{1}' and '{2}'", prof.pro_id.ToString(), inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"));
        }

        public void cancelarPeriodo(DateTime inicio, DateTime fin, int tipo, string razon)
        {
            fin = fin.AddDays(1);
            runner.Insert("INSERT INTO SIGKILL.cancelacion_atencion_medica(cam_profesional,cam_nro_afiliado,cam_tipo_cancelacion,cam_motivo,cam_fecha_turno,cam_fecha_cancelacion)" +
            "(SELECT trn_profesional,trn_afiliado,{2},'{3}',trn_fecha_hora,'{4}' FROM SIGKILL.turno WHERE  trn_fecha_hora between '{0}' and '{1}')",  inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"), tipo.ToString(), razon, Properties.Settings.Default.Date.ToString("yyyy-MM-dd"));
            runner.Delete("DELETE FROM SIGKILL.turno WHERE trn_fecha_hora between '{0}' and '{1}'", inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"));
        }

        private void btn_afiliado_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Afiliado.frmAfiliadoListado(3).Show();
        }

        private void btn_profesional_Click(object sender, EventArgs e)
        {
            new Clinica_Frba.Abm_de_Profesional_Listado.frm_ABMpro_listado(3).Show();
        }



    }
}
