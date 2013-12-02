using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Sql;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Consulta
    {
        public long cons_id { get; set; }
        public long cons_turno { get; set; }
        public long cons_bono_consulta { get; set; }
        public TimeSpan cons_fecha_hora_llegada { get; set; }
        public TimeSpan cons_fecha_hora_atencion { get; set; }
        public String cons_sintomas { get; set; }
        public String cons_diagnostico { get; set; }

        public static Consulta newFromId(long id)
        {
            return new Adapter().Transform<Consulta>(new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString).Single("SELECT * FROM SIGKILL.Consulta WHERE cons_id={0} AND cons_valido=1", id.ToString()));
        }
    }
}
