using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Turno
    {
        public long  trn_id  { get; set; }
        public long  trn_profesional { get; set; }
        public long  trn_afiliado  { get; set; }
        public DateTime trn_fecha_hora { get; set; }
        public int trn_valido { get; set; }
        public long trn_agenda { get; set; }
    }
}
