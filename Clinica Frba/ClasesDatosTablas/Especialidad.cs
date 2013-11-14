using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Especialidad
    {
        public long esp_id  { get; set; }
        public string esp_nombre_especialidad { get; set; }
        public long esp_tipo { get; set; }

        public override string ToString()
        {
            return esp_nombre_especialidad;
        }
    }
}
