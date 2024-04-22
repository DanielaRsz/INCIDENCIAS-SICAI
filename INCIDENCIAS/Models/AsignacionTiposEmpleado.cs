using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class AsignacionTiposEmpleado
    {
        public AsignacionTiposEmpleado()
        {
            Incidencia = new HashSet<Incidencia>();
        }

        public int IdTipoEmpleado { get; set; }
        public int? NucEmpleados { get; set; }
        public string? Descripcion { get; set; }
        public int? IdDocumento { get; set; }
        public int? IdConfTipoEmpleado { get; set; }
        public int? IdCatalogotipodeEmpleado { get; set; }
        public int? IdDocumentos { get; set; }

        public virtual CatalogoTipoEmpleado? IdCatalogotipodeEmpleadoNavigation { get; set; }
        public virtual ConfiguracionTipoEmpleado? IdConfTipoEmpleadoNavigation { get; set; }
        public virtual ICollection<Incidencia> Incidencia { get; set; }
    }
}
