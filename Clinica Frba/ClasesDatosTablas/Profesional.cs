using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

        public void darDeBaja()
        {
            cancelarTodasAtencionesProfesional();
            runner.Update("UPDATE SIGKILL.profesional SET pro_habilitado=0 WHERE pro_id={0}", this.pro_id);
        }
        public void cancelarTodasAtencionesProfesional()
        {            
            DateTime fin =  Properties.Settings.Default.Date;
            fin.AddDays(1);
            runner.Insert("INSERT INTO SIGKILL.cancelacion_atencion_medica(cam_profesional,cam_nro_afiliado,cam_tipo_cancelacion,cam_motivo,cam_fecha_turno,cam_fecha_cancelacion,cam_turno_id)" +
            "(SELECT trn_profesional,trn_afiliado,{1},'{2}',trn_fecha_hora,'{3}',trn_id FROM SIGKILL.turno WHERE  trn_fecha_hora > '{0}' AND trn_profesional = {4} AND trn_id not in (SELECT cons_turno FROM SIGKILL.consulta WHERE cons_valido=1) AND trn_valido=1)", fin.ToString("yyyy-MM-dd"), "7", "Baja de Profesional", Properties.Settings.Default.Date.ToString("yyyy-MM-dd"), this.pro_id);
            runner.Delete("UPDATE SIGKILL.turno SET trn_valido=0 WHERE trn_fecha_hora > '{0}' AND trn_profesional = {1} AND trn_id not in (SELECT cons_turno FROM SIGKILL.consulta WHERE cons_valido=1) AND trn_valido=1", fin.ToString("yyyy-MM-dd"), pro_id);
        }

        public IList<Especialidad> especialidades()
        {
            return new Adapter().TransformMany<Especialidad>(runner.Select("SELECT [esp_id],[esp_nombre_especialidad],[esp_tipo] FROM SIGKILL.esp_prof,SIGKILL.especialidad WHERE espprof_especialidad=esp_id AND espprof_profesional={0}", this.pro_id));
        }

        public void actualizar(Profesional prof,List<Especialidad> especialidades)
        {
            foreach (Especialidad esp in especialidades)
            {
                if (!prof.especialidades().Any(x => x.esp_id == esp.esp_id))
                    runner.Insert("INSERT INTO SIGKILL.esp_prof(espprof_profesional,espprof_especialidad)"
                        + "VALUES ({0},{1})", prof.pro_id, esp.esp_id);
            }
            foreach (Especialidad esp in prof.especialidades())
            {
                if(!especialidades.Any(y=> y.esp_id==esp.esp_id))
                    runner.Delete("DELETE FROM SIGKILL.esp_prof WHERE espprof_profesional={0} AND espprof_especialidad={1}", prof.pro_id, esp.esp_id);
            }
            if (pro_apellido != prof.pro_apellido)
                runner.Update("UPDATE SIGKILL.profesional SET pro_apellido='{0}' WHERE pro_id={1}", pro_apellido,pro_id);
            if (pro_nombre != prof.pro_nombre)
                runner.Update("UPDATE SIGKILL.profesional SET pro_nombre='{0}' WHERE pro_id={1}", pro_nombre,pro_id);
            if (pro_direccion != prof.pro_direccion)
                runner.Update("UPDATE SIGKILL.profesional SET pro_direccion='{0}' WHERE pro_id={1}", pro_direccion,pro_id);
            if (pro_mail != prof.pro_mail)
                runner.Update("UPDATE SIGKILL.profesional SET pro_mail='{0}' WHERE pro_id={1}", pro_mail,pro_id);
            if (pro_nacimiento != prof.pro_nacimiento)
                runner.Update("UPDATE SIGKILL.profesional SET pro_nacimiento='{0}' WHERE pro_id={1}", pro_nacimiento.ToString("yyyy-MM-dd"),pro_id);
            if (pro_sexo != prof.pro_sexo)
                runner.Update("UPDATE SIGKILL.profesional SET pro_sexo='{0}' WHERE pro_id={1}", pro_sexo,pro_id);
            if (pro_telefono != prof.pro_telefono)
                runner.Update("UPDATE SIGKILL.profesional SET pro_telefono={0} WHERE pro_id={1}", pro_telefono,pro_id);
            if (pro_matricula != prof.pro_matricula)
                runner.Update("UPDATE SIGKILL.profesional SET pro_matricula={0} WHERE pro_id={1}", pro_matricula,pro_id);
        }

    }
}
