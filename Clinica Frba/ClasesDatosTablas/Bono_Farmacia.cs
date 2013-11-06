using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Bono_Farmacia
    {
        public long bonof_id { get; set; }
        public long bonof_afiliado { get; set; }
        public long bonof_consulta { get; set; }
        public DateTime bonof_fecha_compra { get; set; }
        public long bonof_plan_medico { get; set; }
        public long bonof_consumido { get; set; }
        public double bonof_precio { get; set; }
        
        public bool esValidoPara(Afiliado afil)
        {
            return afil.getNumeroAfiliadoPrincipal() == afil.numeroAfiliadoPrincipal(Convert.ToInt64(this.bonof_afiliado));
        }
    }

    
}
