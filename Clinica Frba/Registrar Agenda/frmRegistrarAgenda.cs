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

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class frmRegistrarAgenda : Form
    {
        Profesional prof = new Adapter().Transform<Profesional>(new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString).Single("SELECT * FROM SIGKILL.profesional WHERE pro_id=1"));
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
        public frmRegistrarAgenda()
        {
            InitializeComponent();
        }
        public frmRegistrarAgenda(Profesional p)
        {
            InitializeComponent();
            prof = p;
        }


        private void frmRegistrarAgenda_Load(object sender, EventArgs e)
        {
            dtp_fin.Value = dtp_inicio.Value=Properties.Settings.Default.Date;
            lbl_profesional.Text = prof.pro_apellido + ", " + prof.pro_nombre;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtp_inicio.Value.ToString("yyyy-MM-dd"));
            
            if (dtp_inicio.Value.CompareTo(dtp_fin.Value) > 0)
                {MessageBox.Show("Has ingresado mal el rango de Fechas"); return;};
            TimeSpan span=dtp_fin.Value-Properties.Settings.Default.Date;
            if (span.TotalDays > 120)
                {MessageBox.Show("Ingresó un rango de fechas que comienza en "+ span.TotalDays.ToString()+" días. El rango de fechas debe estar entre los próximos 120 días como máximo","Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);return;}
            if (chk_lunes.Checked && (combo_lunes_inicio.SelectedIndex > combo_lunes_fin.SelectedIndex || combo_lunes_inicio.SelectedIndex<0 ||combo_lunes_fin.SelectedIndex<0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del lunes", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_martes.Checked && (combo_martes_inicio.SelectedIndex > combo_martes_fin.SelectedIndex || combo_martes_inicio.SelectedIndex < 0 || combo_martes_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del martes", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_miercoles.Checked && (combo_miercoles_inicio.SelectedIndex > combo_miercoles_fin.SelectedIndex || combo_miercoles_inicio.SelectedIndex < 0 || combo_miercoles_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del miercoles", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_jueves.Checked && (combo_jueves_inicio.SelectedIndex > combo_jueves_fin.SelectedIndex || combo_jueves_inicio.SelectedIndex < 0 || combo_jueves_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del jueves", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_viernes.Checked && (combo_viernes_inicio.SelectedIndex > combo_viernes_fin.SelectedIndex || combo_viernes_inicio.SelectedIndex < 0 || combo_viernes_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del viernes", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_sabado.Checked && (combo_sabado_inicio.SelectedIndex > combo_sabado_fin.SelectedIndex || combo_sabado_inicio.SelectedIndex < 0 || combo_sabado_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del sabado", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (cant_horas_semanales()>48)
            { MessageBox.Show("Has Ingresado mas de 48 semanales para el profesional", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            try
            {
                var collision = runner.Single("Select COUNT(*) as cant FROM SIGKILL.agenda_profesional WHERE agp_profesional={0} AND DATEDIFF(day,agp_fecha_fin,'{1}') <= 0 AND DATEDIFF(day,agp_fecha_inicio,'{2}') >= 0", prof.pro_id.ToString(),dtp_inicio.Value.ToString("yyyy-MM-dd"), dtp_fin.Value.ToString("yyyy-MM-dd"));
                if ((int)collision["cant"] != 0)
                    throw new System.ArgumentException("Se encontro otro período registrado que colisiona con el rango de fechas especificadas. Por favor, ingrese otro rango.");
                runner.Insert("INSERT INTO SIGKILL.agenda_profesional(agp_fecha_inicio,agp_fecha_fin,agp_profesional)" +
                    "VALUES ('{0}','{1}',{2})", dtp_inicio.Value.ToString("yyyy-MM-dd"), dtp_fin.Value.ToString("yyyy-MM-dd"), prof.pro_id.ToString());
                Filters f = new Filters();
                f.AddEqual("agp_fecha_inicio", dtp_inicio.Value.ToString("yyyy-MM-dd"));
                f.AddEqual("agp_fecha_fin", dtp_fin.Value.ToString("yyyy-MM-dd"));
                f.AddEqual("agp_profesional", prof.pro_id.ToString());
                var res = runner.Single("SELECT agp_id FROM SIGKILL.agenda_profesional", f);
                //MessageBox.Show(res["agp_id"].ToString());

                if (chk_lunes.Checked)
                {
                    runner.Insert("INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)" +
                        "VALUES ({0},'{1}','{2}',2)", res["agp_id"].ToString(), combo_lunes_inicio.Text, combo_lunes_fin.Text);
                }

                if (chk_martes.Checked)
                {
                    runner.Insert("INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)" +
                        "VALUES ({0},'{1}','{2}',3)", res["agp_id"].ToString(), combo_martes_inicio.Text, combo_martes_fin.Text);
                }

                if (chk_miercoles.Checked)
                {
                    runner.Insert("INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)" +
                        "VALUES ({0},'{1}','{2}',4)", res["agp_id"].ToString(), combo_miercoles_inicio.Text, combo_miercoles_fin.Text);
                }

                if (chk_jueves.Checked)
                {
                    runner.Insert("INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)" +
                        "VALUES ({0},'{1}','{2}',5)", res["agp_id"].ToString(), combo_jueves_inicio.Text, combo_jueves_fin.Text);
                }

                if (chk_viernes.Checked)
                {
                    runner.Insert("INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)" +
                        "VALUES ({0},'{1}','{2}',6)", res["agp_id"].ToString(), combo_viernes_inicio.Text, combo_viernes_fin.Text);
                }

                if (chk_sabado.Checked)
                {
                    runner.Insert("INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)" +
                        "VALUES ({0},'{1}','{2}',7)", res["agp_id"].ToString(), combo_sabado_inicio.Text, combo_sabado_fin.Text);
                }
                MessageBox.Show("Se ha agregado en la Agenda Correctamente", "Registrar agenda");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private double cant_horas_semanales()
        {
            double cant = 0;
            if (chk_lunes.Checked)
            {
               cant+=(-combo_lunes_inicio.SelectedIndex + combo_lunes_fin.SelectedIndex +1 )*0.5; 
            }

            if (chk_martes.Checked)
            {
                cant += (-combo_martes_inicio.SelectedIndex + combo_martes_fin.SelectedIndex + 1) * 0.5; 
            }

            if (chk_miercoles.Checked)
            {
                cant += (-combo_miercoles_inicio.SelectedIndex + combo_miercoles_fin.SelectedIndex + 1) * 0.5; 
            }

            if (chk_jueves.Checked)
            {
                cant += (-combo_jueves_inicio.SelectedIndex + combo_jueves_fin.SelectedIndex + 1) * 0.5; 
            }

            if (chk_viernes.Checked)
            {
                cant += (-combo_viernes_inicio.SelectedIndex + combo_viernes_fin.SelectedIndex + 1) * 0.5; 
            }

            if (chk_sabado.Checked)
            {
                cant += (-combo_sabado_inicio.SelectedIndex + combo_sabado_fin.SelectedIndex + 1) * 0.5; 
            }
            return cant;
        }



    }
}
