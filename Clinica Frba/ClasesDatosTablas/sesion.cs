using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.ClasesDatosTablas;
using Clinica_Frba.Sql;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class sesion
    {
        public Usuario usuario { get; set; }
        public Rol rol { get; set; }

        public string WelcomeMessage
        {
            get
            {
                try
                {
                    if (this.rol.rol_nombre == "Administrador")
                    {
                        return string.Format("¡Bienvenido {0}! ({1})", this.usuario.usr_usuario, this.rol.rol_nombre);
                    }
                    if (this.rol.rol_nombre == "Profesional")
                    {
                        return string.Format("¡Bienvenido {0} {1}! ({2})", this.usuario.getProfesional().pro_nombre, this.usuario.getProfesional().pro_apellido, this.rol.rol_nombre);
                    }
                    if (this.rol.rol_nombre == "Afiliado")
                    {
                        return string.Format("¡Bienvenido {0} {1}! ({2})", this.usuario.getAfiliado().afil_nombre, this.usuario.getAfiliado().afil_apellido, this.rol.rol_nombre);
                    }
                    else 
                    {
                        return "No posee roles";
                    }
                }
                catch
                {
                    return "SE ROMPIO TODO";
                }
            }
        }
    
    }
}
