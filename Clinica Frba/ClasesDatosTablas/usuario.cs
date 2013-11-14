using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ClasesDatosTablas;
using Clinica_Frba.Sql;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Usuario
    {
        public long usr_id { get; set; }
        public string usr_usuario { get; set; }
        public string usr_password { get; set; }
        public int usr_cant_login_fail { get; set; }
        public int usr_estado { get; set; }
        
        //public virtual string WelcomeMessage
        //{
        //    get { return string.Format("¡Bienvenido {0}!", this.usr_usuario.ToUpper()); }
        //}

        public Usuario() { }

        public Usuario(Usuario usuario)
        {
            this.usr_password = usuario.usr_password;
            this.usr_usuario = usuario.usr_usuario;
        }

        public int EstaBloqueado
        {
            get
            {
                if (this.usr_cant_login_fail >= 3)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public Afiliado getAfiliado()
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            var result = runner
                    .Single("SELECT * FROM SIGKILL.afiliado WHERE afil_usuario={0}",this.usr_id.ToString());
            return new Adapter().Transform<Afiliado>(result);
        }

        public Profesional getProfesional()
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            var result = runner
                    .Single("SELECT * FROM SIGKILL.profesional WHERE pro_usuario={0}", this.usr_id.ToString());
            return new Adapter().Transform<Profesional>(result);
        }

        //public bool EstaBloqueado
        //{
        //    get { return this.usr_cant_login_fail >= 3; }
        //}

        public bool hasAfiliado()
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            var result = runner
                    .Single("SELECT COUNT(*) as cant FROM SIGKILL.afiliado WHERE afil_usuario={0}", this.usr_id.ToString());
            return (int)result["cant"] == 1;
        }

        public bool hasProfesional()
        {
            SqlRunner runner = new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString);
            var result = runner
                    .Single("SELECT COUNT(*) as cant FROM SIGKILL.profesional WHERE pro_usuario={0}", this.usr_id.ToString());
            return (int)result["cant"] == 1;
        }




        public static Usuario newFromId(long p)
        {
            return new Adapter().Transform<Usuario>(new SqlRunner(Properties.Settings.Default.GD2C2013ConnectionString).Single("SELECT * FROM SIGKILL.usuario WHERE usr_id={0}", p.ToString()));
        }
    }
}

