using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Plan_Medico
    {
        public long pmed_id { get; set; }
        public string pmed_nombre { get; set; }
        public long pmed_precio { get; set; }
        public long pmed_precio_bono_consulta { get; set; }
        public long pmed_precio_bono_farmacia { get; set; }
    }
}
