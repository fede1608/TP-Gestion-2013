using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Bono_Consulta
    {
        public long bonoc_id  { get; set; }
        public long bonoc_afiliado  { get; set; }
        public DateTime bonoc_fecha_compra { get; set; }
        public long bonoc_plan_medico  { get; set; }
        public long bonoc_nro_consulta_individual { get; set; }
        public long bonoc_consumido { get; set; }
        public double bonoc_precio { get; set; }
        public long bonoc_compra { get; set; }

        public bool esValidoPara(Afiliado afil)
        {
            return afil.getNumeroAfiliadoPrincipal() == afil.numeroAfiliadoPrincipal(Convert.ToInt64(this.bonoc_afiliado));
        }
    }
}
