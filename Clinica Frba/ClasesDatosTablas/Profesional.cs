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
        public int pro_habilitado { get; set; }

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



    }
}
