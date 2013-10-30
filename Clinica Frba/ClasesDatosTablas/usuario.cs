using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ClasesDatosTablas;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Usuario
    {
        public long usr_id { get; set; }
        public string usr_usuario { get; set; }
        public string usr_password { get; set; }
        public int usr_cant_login_fail { get; set; }
        public int usr_estado { get; set; }
        
        public virtual string WelcomeMessage
        {
            get { return string.Format("¡Bienvenido {0}!", this.usr_usuario.ToUpper()); }
        }

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

        //public bool EstaBloqueado
        //{
        //    get { return this.usr_cant_login_fail >= 3; }
        //}



    }
}

