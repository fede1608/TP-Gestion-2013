using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Sql;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Afiliado
    {
        public long afil_numero  { get; set; }
        public long afil_usuario { get; set; }
        public string afil_nombre { get; set; }
        public string afil_apellido { get; set; }
        public long afil_tipo_doc { get; set; }
        public long afil_dni { get; set; }
        public string afil_direccion { get; set; }
        public long afil_telefono { get; set; }
        public string afil_mail { get; set; }
        public DateTime afil_nacimiento { get; set; }
        public string afil_sexo { get; set; }
        public long afil_estado_civil { get; set; }
        public int afil_cant_hijos { get; set; }
        public int afil_cant_fam_a_cargo { get; set; }
        public long afil_id_plan_medico { get; set; }
        public int afil_activo { get; set; }

        SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);

        public string getName()
        {
            return afil_apellido+", "+afil_nombre;
        }

        public long getNumeroAfiliadoPrincipal()
        {
            return numeroAfiliadoPrincipal(afil_numero);
        }

        public long numeroAfiliadoPrincipal(long afil_numero)
        {
            return (long) Math.Floor((double)afil_numero / 100);
        }

        public static Afiliado newFromId(long id)
        {
            return new Adapter().Transform<Afiliado>(new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString).Single("SELECT * FROM SIGKILL.Afiliado WHERE afil_numero={0}", id.ToString()));
        }

        public String parsearSexo(String sexo)
        {
            if (sexo == "Masculino")
                return "M";
            else if (sexo == "Femenino")
                return "F";
            else
                return "D";
        }

        public long parsearEstadoCivil(String estado_civil_texto)
        {
            var result = runner.Single("SELECT estciv_id from GD2C2013.SIGKILL.estado_civil where estciv_descripcion = '{0}'", estado_civil_texto);
            return (long)result[0];

        }
        
        public long parsearPlanMedico(String plan_medico_texto)
        {
            var result = runner.Single("SELECT pmed_id FROM GD2C2013.SIGKILL.plan_medico WHERE pmed_nombre = '{0}'",plan_medico_texto);
            return (long)result[0];
        }

        public Boolean commit()
        {
            runner.Update("UPDATE SIGKILL.afiliado SET afil_direccion='{0}', afil_telefono={1}, afil_mail='{2}', afil_sexo='{3}', afil_estado_civil={4}, afil_id_plan_medico={5}, afil_activo={6} WHERE afil_numero={7}",
                    afil_direccion, afil_telefono, afil_mail, afil_sexo, afil_estado_civil, afil_id_plan_medico, afil_activo, afil_numero);

            return true;
        }

        public void darDeBaja()
        {
            afil_activo = 0;
            commit();
        }
    }
}
