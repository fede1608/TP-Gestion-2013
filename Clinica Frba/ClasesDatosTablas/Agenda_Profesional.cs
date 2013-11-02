using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Agenda_Profesional
    {
        public long agp_id  { get; set; }
        public DateTime agp_fecha_inicio { get; set; }
        public DateTime agp_fecha_fin { get; set; }
        public long agp_profesional { get; set; }
        public int agp_disponible { get; set; }
    }
}
