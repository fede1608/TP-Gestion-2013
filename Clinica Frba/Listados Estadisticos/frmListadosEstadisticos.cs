using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.ClasesDatosTablas;

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class frmListadosEstadisticos : Form
    {
        public frmListadosEstadisticos()
        {
            InitializeComponent();
        }

        private void combo_semestre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_top1.Enabled = true;
            btn_top2.Enabled = true;
            btn_top3.Enabled = true;
            btn_top4.Enabled = true;

        }

        private void btn_top1_Click(object sender, EventArgs e)
        {
            var est = new Estadistica();
            est.name = ((Button)sender).Text;
            est.consulta = "SELECT TOP 5 esp_nombre_especialidad as Especialidad,Count(*) as Cantidad FROM SIGKILL.cancelacion_atencion_medica,SIGKILL.profesional,SIGKILL.esp_prof,SIGKILL.especialidad WHERE cam_profesional=pro_id AND pro_id=espprof_profesional AND espprof_especialidad=esp_id AND cam_tipo_cancelacion in (2,3,4,5) AND MONTH(cam_fecha_cancelacion) in ({0}) AND YEAR(cam_fecha_cancelacion) ={1} GROUP BY esp_nombre_especialidad ORDER BY 2 DESC,1 DESC";
            est.semestre = combo_semestre.SelectedIndex+1;
            new Clinica_Frba.Listados_Estadisticos.frmResultadosEstadisticos(est).Show();
        }

        private void btn_top2_Click(object sender, EventArgs e)
        {
            var est = new Estadistica();
            est.name = ((Button)sender).Text;
            est.consulta = String.Format("SELECT TOP 5 afil_nombre as Nombre,afil_apellido as Apellido,COUNT(*) as Cantidad FROM SIGKILL.bono_farmacia,SIGKILL.afiliado WHERE bono_farmacia.bonof_afiliado=afil_numero AND bonof_consumido=0  AND DATEADD(day,90,bonof_fecha_compra)<'{0}' AND MONTH(DATEADD(day,90,bonof_fecha_compra)) in ({1}) AND YEAR(DATEADD(day,90,bonof_fecha_compra)) ={2} GROUP BY afil_numero,afil_nombre,afil_apellido ORDER BY 3 DESC,2 DESC,1 DESC", Properties.Settings.Default.Date.ToString("yyyy-MM-dd"), "{0}", "{1}");
            est.semestre = combo_semestre.SelectedIndex + 1;
            new Clinica_Frba.Listados_Estadisticos.frmResultadosEstadisticos(est).Show();
        }

        private void btn_top3_Click(object sender, EventArgs e)
        {
            var est = new Estadistica();
            est.name = ((Button)sender).Text;
            est.consulta = "SELECT TOP 5 esp_nombre_especialidad, COUNT(*) FROM SIGKILL.bono_farmacia,SIGKILL.consulta,SIGKILL.turno,SIGKILL.profesional,SIGKILL.esp_prof,SIGKILL.especialidad WHERE bonof_consumido=1 AND bonof_consulta=cons_id AND cons_turno=trn_id AND trn_profesional=pro_id AND pro_id=espprof_profesional AND espprof_especialidad=esp_id AND MONTH(trn_fecha_hora) in ({0}) AND YEAR(trn_fecha_hora)={1} AND trn_valido=1 GROUP BY esp_nombre_especialidad ORDER BY 2 DESC,1 DESC";
            est.semestre = combo_semestre.SelectedIndex + 1;
            new Clinica_Frba.Listados_Estadisticos.frmResultadosEstadisticos(est).Show();
        }

        private void btn_top4_Click(object sender, EventArgs e)
        {
            var est = new Estadistica();
            est.name = ((Button)sender).Text;
            est.consulta = "SELECT TOP 10 Nombre,Apellido,SUM(Cantidad) as Cantidad FROM ((SELECT trn_afiliado as num,afil_nombre as Nombre,afil_apellido as Apellido,COUNT(*) as Cantidad 		FROM SIGKILL.bono_consulta,SIGKILL.consulta,SIGKILL.turno,SIGKILL.afiliado 		WHERE bonoc_consumido=1 AND cons_bono_consulta=bonoc_id AND cons_turno=trn_id AND trn_afiliado=afil_numero AND bonoc_afiliado!=trn_afiliado AND MONTH(trn_fecha_hora) in ({0}) AND YEAR(trn_fecha_hora)={1} AND trn_valido=1 	GROUP BY trn_afiliado,afil_nombre,afil_apellido) 		Union 		(SELECT afil_numero as num,afil_nombre as Nombre,afil_apellido as Apellido,COUNT(*) as Cantidad 		FROM SIGKILL.bono_farmacia,SIGKILL.consulta,SIGKILL.turno,SIGKILL.afiliado 		WHERE bonof_consumido=1 AND trn_valido=1 AND trn_afiliado=afil_numero AND bonof_afiliado!=afil_numero AND  cons_id=bonof_consulta AND cons_turno=trn_id AND MONTH(trn_fecha_hora) in ({0}) AND YEAR(trn_fecha_hora)={1} 	GROUP BY afil_numero,afil_nombre,afil_apellido)) as a GROUP BY a.num,a.Nombre,a.Apellido ORDER BY 3 DESC,2 DESC,1 DESC";
            est.semestre = combo_semestre.SelectedIndex + 1;
            new Clinica_Frba.Listados_Estadisticos.frmResultadosEstadisticos(est).Show();
        }


    }
}
