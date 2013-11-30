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
        TimeSpan inicio_semana = TimeSpan.FromHours(7);
        TimeSpan fin_semana = TimeSpan.FromHours(20);
        TimeSpan inicio_sabado = TimeSpan.FromHours(10);
        TimeSpan fin_sabado = TimeSpan.FromHours(15);
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

            for (var hs = inicio_semana.TotalMinutes; hs <= fin_semana.TotalMinutes; hs += 5)
            {
                var ts=TimeSpan.FromMinutes(hs);
                combo_lunes_inicio.Items.Add(ts.ToString());
                combo_martes_inicio.Items.Add(ts.ToString());
                combo_miercoles_inicio.Items.Add(ts.ToString());
                combo_jueves_inicio.Items.Add(ts.ToString());
                combo_viernes_inicio.Items.Add(ts.ToString());
                //combo_lunes_fin.Items.Add(ts.ToString());
                //combo_martes_fin.Items.Add(ts.ToString());
                //combo_miercoles_fin.Items.Add(ts.ToString());
                //combo_jueves_fin.Items.Add(ts.ToString());
                //combo_viernes_fin.Items.Add(ts.ToString());
            }
            for (var hs = inicio_sabado.TotalMinutes; hs <= fin_sabado.TotalMinutes; hs += 5)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_sabado_inicio.Items.Add(ts.ToString());
                //combo_sabado_fin.Items.Add(ts.ToString());
               
            }
            var res = new Adapter().TransformMany<Especialidad>(runner.Select("SELECT esp_id,esp_nombre_especialidad,esp_tipo FROM SIGKILL.especialidad,Sigkill.esp_prof WHERE esp_id=espprof_especialidad AND espprof_profesional={0}",prof.pro_id));
            foreach (Especialidad esp in res)
            {
                combo_especialidad.Items.Add(esp);
            }
            combo_especialidad.DisplayMember = "esp_nombre_especialidad";

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
            if (chk_lunes.Checked && (combo_lunes_inicio.SelectedIndex < 0 || combo_lunes_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del lunes", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_martes.Checked && (combo_martes_inicio.SelectedIndex < 0 || combo_martes_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del martes", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_miercoles.Checked && (combo_miercoles_inicio.SelectedIndex < 0 || combo_miercoles_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del miercoles", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_jueves.Checked && (combo_jueves_inicio.SelectedIndex < 0 || combo_jueves_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del jueves", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_viernes.Checked && (combo_viernes_inicio.SelectedIndex < 0 || combo_viernes_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del viernes", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (chk_sabado.Checked && (combo_sabado_inicio.SelectedIndex < 0 || combo_sabado_fin.SelectedIndex < 0))
            { MessageBox.Show("Has ingresado mal el rango de horarios del sabado", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            if (cant_horas_semanales()>48)
            { MessageBox.Show("Has Ingresado mas de 48 semanales para el profesional", "Registrar agenda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            try
            {
                var collision = runner.Single("Select COUNT(*) as cant FROM SIGKILL.agenda_profesional WHERE agp_profesional={0} AND agp_especialidad in (0,{3}) AND DATEDIFF(day,agp_fecha_fin,'{1}') <= 0 AND DATEDIFF(day,agp_fecha_inicio,'{2}') >= 0", prof.pro_id.ToString(),dtp_inicio.Value.ToString("yyyy-MM-dd"), dtp_fin.Value.ToString("yyyy-MM-dd"),((Especialidad)combo_especialidad.SelectedItem).esp_id.ToString());
                if ((int)collision["cant"] != 0)
                    throw new System.ArgumentException("Se encontro otro período registrado que colisiona con el rango de fechas especificadas. Por favor, ingrese otro rango.");
                runner.Insert("INSERT INTO SIGKILL.agenda_profesional(agp_fecha_inicio,agp_fecha_fin,agp_profesional,agp_especialidad)" +
                    "VALUES ('{0}','{1}',{2},{3})", dtp_inicio.Value.ToString("yyyy-MM-dd"), dtp_fin.Value.ToString("yyyy-MM-dd"), prof.pro_id.ToString(),((Especialidad)combo_especialidad.SelectedItem).esp_id.ToString());
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
               cant+=( combo_lunes_fin.SelectedIndex +1 )*(0.5); 
            }

            if (chk_martes.Checked)
            {
                cant += ( combo_martes_fin.SelectedIndex + 1) * (0.5); 
            }

            if (chk_miercoles.Checked)
            {
                cant += (combo_miercoles_fin.SelectedIndex + 1) * (0.5);
            }

            if (chk_jueves.Checked)
            {
                cant += (combo_jueves_fin.SelectedIndex + 1) * (0.5);
            }

            if (chk_viernes.Checked)
            {
                cant += (combo_viernes_fin.SelectedIndex + 1) * (0.5);
            }

            if (chk_sabado.Checked)
            {
                cant += (combo_sabado_fin.SelectedIndex + 1) * (0.5);
            }
            return cant;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_sabado_fin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chk_sabado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combo_lunes_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_lunes.Checked = true;
            combo_lunes_fin.Items.Clear();
            TimeSpan inicio = TimeSpan.Parse((String)combo_lunes_inicio.SelectedItem);
            for (var hs = inicio.TotalMinutes+30; hs <= fin_semana.TotalMinutes; hs += 30)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_lunes_fin.Items.Add(ts.ToString());

            }
        }

        private void combo_martes_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_martes.Checked = true;
            combo_martes_fin.Items.Clear();
            TimeSpan inicio = TimeSpan.Parse((String)combo_martes_inicio.SelectedItem);
            for (var hs = inicio.TotalMinutes + 30; hs <= fin_semana.TotalMinutes; hs += 30)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_martes_fin.Items.Add(ts.ToString());

            }
        }

        private void combo_miercoles_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_miercoles.Checked = true;
            combo_miercoles_fin.Items.Clear();
            TimeSpan inicio = TimeSpan.Parse((String)combo_miercoles_inicio.SelectedItem);
            for (var hs = inicio.TotalMinutes + 30; hs <= fin_semana.TotalMinutes; hs += 30)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_miercoles_fin.Items.Add(ts.ToString());

            }
        }

        private void combo_jueves_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_jueves.Checked = true;
            combo_jueves_fin.Items.Clear();
            TimeSpan inicio = TimeSpan.Parse((String)combo_jueves_inicio.SelectedItem);
            for (var hs = inicio.TotalMinutes + 30; hs <= fin_semana.TotalMinutes; hs += 30)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_jueves_fin.Items.Add(ts.ToString());

            }
        }

        private void combo_viernes_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_viernes.Checked = true;
            combo_viernes_fin.Items.Clear();
            TimeSpan inicio = TimeSpan.Parse((String)combo_viernes_inicio.SelectedItem);
            for (var hs = inicio.TotalMinutes + 30; hs <= fin_semana.TotalMinutes; hs += 30)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_viernes_fin.Items.Add(ts.ToString());

            }
        }

        private void combo_sabado_inicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_sabado.Checked = true;
            combo_sabado_fin.Items.Clear();
            TimeSpan inicio = TimeSpan.Parse((String)combo_sabado_inicio.SelectedItem);
            for (var hs = inicio.TotalMinutes + 30; hs <= fin_sabado.TotalMinutes; hs += 30)
            {
                var ts = TimeSpan.FromMinutes(hs);
                combo_sabado_fin.Items.Add(ts.ToString());

            }
        }



    }
}
