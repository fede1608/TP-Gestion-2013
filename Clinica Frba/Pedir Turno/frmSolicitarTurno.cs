﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ClasesDatosTablas;
using Clinica_Frba.Sql;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class frmSolicitarTurno : Form
    {
        public Afiliado afil;
        public Profesional prof;
        public IList<Agenda_Profesional> agendas;
        public Especialidad especialidad;
        public String fecha;
        public DateTime fechaTurno;
        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public frmSolicitarTurno(Afiliado a)
        {
            afil = a;
            InitializeComponent();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolicitarTurno_Load(object sender, EventArgs e)
        {
            lbl_afiliado.Text = afil.getName();
            combo_fecha.Enabled = false;
            combo_fecha.Items.Clear();
            comboHorario.Enabled = false;
            comboHorario.Items.Clear();
            combo_profesional.Enabled = false;
            combo_profesional.Items.Clear();
            btn_aceptar.Enabled = false;
            var res = new Adapter().TransformMany<Especialidad>(runner.Select("SELECT * FROM SIGKILL.especialidad WHERE esp_id>0 ORDER BY esp_nombre_especialidad"));
            foreach (Especialidad esp in res)
            {
                combo_especialidad.Items.Add(esp);
            }
            combo_especialidad.DisplayMember = "esp_nombre_especialidad";
        }

        private void combo_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_profesional.Enabled = true;
            combo_profesional.Items.Clear();
            especialidad = ((Especialidad)combo_especialidad.SelectedItem);
            var res = new Adapter().TransformMany<Profesional>(runner.Select("SELECT pro_id,pro_matricula,pro_usuario,pro_nombre,pro_apellido,pro_tipo_doc,pro_dni,pro_direccion,pro_telefono,pro_mail,	pro_nacimiento,	pro_sexo,pro_cant_hs_acum  FROM SIGKILL.profesional,SIGKILL.esp_prof WHERE espprof_profesional=pro_id AND espprof_especialidad={0} AND pro_habilitado=1",((Especialidad)combo_especialidad.SelectedItem).esp_id.ToString()));
            foreach (Profesional p in res)
            {
                combo_profesional.Items.Add(p);
            }
            combo_profesional.DisplayMember = "nombreCompleto";
            combo_fecha.Enabled = false;
            combo_fecha.Items.Clear();
            comboHorario.Enabled = false;
            comboHorario.Items.Clear();
            btn_aceptar.Enabled = false;
        }

        private void combo_profesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_fecha.Enabled = true;
            combo_fecha.Items.Clear();
            prof = (Profesional)combo_profesional.SelectedItem;
            var res = new Adapter().TransformMany<Agenda_Profesional>(runner.Select("SELECT * FROM SIGKILL.agenda_profesional WHERE agp_profesional={0} and agp_especialidad in(0,{1})",prof.pro_id.ToString(),especialidad.esp_id));
            foreach (Agenda_Profesional agp in res)
            {
                var hags = new Adapter().TransformMany<Horario_Agenda>(runner.Select("SELECT * FROM SIGKILL.horario_Agenda WHERE hag_id_agenda={0}",agp.agp_id.ToString()));
                for (var dt = agp.agp_fecha_inicio; dt <= agp.agp_fecha_fin; dt = dt.AddDays(1))
                {
                    if (hags.Any(hg => hg.diaSemana() == dt.DayOfWeek))
                    {
                        var turnosEnElDia = runner.Single("SELECT COUNT(*) as cant FROM SIGKILL.turno WHERE  DAY(trn_fecha_hora)={0}  AND MONTH(trn_fecha_hora) = {1} AND YEAR(trn_fecha_hora)={2} AND trn_profesional={3}", dt.Day.ToString(), dt.Month.ToString(), dt.Year.ToString(), prof.pro_id.ToString());
                        int cant= (int)turnosEnElDia["cant"];
                        Horario_Agenda hagActual=null;
                        foreach (Horario_Agenda hag in hags)
                        {
                            if (hag.diaSemana() == dt.DayOfWeek)
                                hagActual = hag;
                        }
                        if(hagActual.cantMaxTurnos()>cant)
                            combo_fecha.Items.Add(dt.ToString("dddd, yyyy-MM-dd"));
                    }
                }
                
            }
            comboHorario.Enabled = false;
            comboHorario.Items.Clear();
            btn_aceptar.Enabled = false;
        }

        private void combo_fecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            fecha = combo_fecha.Text.Split(',')[1];
            fechaTurno = DateTime.Parse(fecha);
            comboHorario.Enabled = true;
            comboHorario.Items.Clear();
            var hag = new Adapter().Transform<Horario_Agenda>(runner.Single("SELECT hag_id,hag_horario_inicio,hag_horario_fin,hag_id_agenda,hag_dia_semana,hag_disponible FROM SIGKILL.horario_Agenda,SIGKILL.agenda_profesional WHERE agp_id=hag_id_agenda AND agp_profesional={0} AND hag_dia_semana={1} AND CONVERT(datetime,'{2}',101) between agp_fecha_inicio AND agp_fecha_fin", prof.pro_id.ToString(), (((int)(DateTime.Parse(fecha).DayOfWeek)) + 1).ToString(), fecha));
            var turnos = new Adapter().TransformMany<Turno>(runner.Select("SELECT * FROM SIGKILL.Turno WHERE trn_profesional={0} AND DATEDIFF(day,trn_fecha_hora,CONVERT(datetime,'{1}',101))=0 AND trn_valido=1", prof.pro_id.ToString(), fecha));
            for (var hs = hag.hag_horario_inicio.TotalMinutes; hs <= hag.hag_horario_fin.TotalMinutes; hs+=30)
            {
                var ts=TimeSpan.FromMinutes(hs);
                
                //if (ts.Minutes == 0 || ts.Minutes == 30)
                //{
                    var dt = DateTime.Parse(fecha + " " + ts.ToString());
                    if(turnos.All(t => !t.trn_fecha_hora.Equals(dt)))
                        comboHorario.Items.Add(ts.ToString());
                //}
            }
            btn_aceptar.Enabled = false;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            fecha += " " + comboHorario.Text;
            try
            {
                Agenda_Profesional agp= new Adapter().Transform<Agenda_Profesional>(runner.Single("SELECT * from SIGKILL.agenda_profesional WHERE CONVERT(datetime,'{0}',101) BETWEEN agp_fecha_inicio AND agp_fecha_fin AND agp_profesional={1} AND agp_especialidad in (0,{2})",fechaTurno.ToString("yyyy-MM-dd"),prof.pro_id.ToString(),especialidad.esp_id.ToString()));
                var next = runner.Single("SELECT MAX(trn_id)+1 as next FROM SIGKILL.turno");
                runner.Insert("INSERT INTO SIGKILL.Turno(trn_id,trn_afiliado,trn_profesional,trn_fecha_hora,trn_agenda)" +
                    "VALUES ({0},{1},{2},CONVERT(datetime,'{3}',101),{4})", next["next"].ToString(), afil.afil_numero.ToString(), prof.pro_id.ToString(), fecha,agp.agp_id.ToString());

                MessageBox.Show("El turno se ha creado correctamente. Su numero de Turno es: " + next["next"].ToString(), "Solicitar turno");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_aceptar.Enabled = true;
        }


    }
}
