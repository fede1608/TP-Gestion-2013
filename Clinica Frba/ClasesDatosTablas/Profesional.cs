using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public long pro_nro_doc{ get; set; }
        public string pro_direccion{ get; set; }
        public long pro_telefono{ get; set; }
        public string pro_mail{ get; set; }
        public DateTime pro_nacimiento{ get; set; }
        public string pro_sexo{ get; set; }
        public int pro_cant_hs_acum{ get; set; }


    }
}
