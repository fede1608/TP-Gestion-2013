using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Sql;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Profesional
    {
        public long pro_id { get; set; }
        public long pro_matricula{ get; set; }
        public long pro_usuario { get; set; }
        public string pro_nombre{ get; set; }
        public string pro_apellido{ get; set; }
        public int pro_tipo_doc { get; set; }
        public long pro_dni{ get; set; }
        public string pro_direccion{ get; set; }
        public long pro_telefono{ get; set; }
        public string pro_mail{ get; set; }
        public DateTime pro_nacimiento{ get; set; }
        public string pro_sexo{ get; set; }
        public int pro_cant_hs_acum{ get; set; }

        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public string getName()
        {
            return pro_apellido + ", " + pro_nombre;
        }
        public string nombreCompleto
        {
            get
            {
                return pro_apellido + ", " + pro_nombre;
            }
            set
            {
            }
        }
        public static Profesional newFromId(long id)
        {
            return new Adapter().Transform<Profesional>(new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString).Single("SELECT * FROM SIGKILL.profesional WHERE pro_id={0}",id.ToString()));
        }

        public void cancelarPeriodo(DateTime inicio, DateTime fin, int tipo, string razon)
        {
            fin=fin.AddDays(1);
            runner.Insert("INSERT INTO SIGKILL.cancelacion_atencion_medica(cam_profesional,cam_nro_afiliado,cam_tipo_cancelacion,cam_motivo,cam_fecha_turno,cam_fecha_cancelacion)" +
            "(SELECT trn_profesional,trn_afiliado,{3},'{4}',trn_fecha_hora,'{5}' FROM SIGKILL.turno WHERE trn_profesional={0} AND trn_fecha_hora between '{1}' and '{2}')", this.pro_id.ToString(), inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"),tipo.ToString(),razon,Properties.Settings.Default.Date.ToString("yyyy-MM-dd"));
            runner.Delete("DELETE FROM SIGKILL.turno WHERE trn_profesional={0} AND trn_fecha_hora between '{1}' and '{2}'", this.pro_id.ToString(), inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"));
        }

    }
}
