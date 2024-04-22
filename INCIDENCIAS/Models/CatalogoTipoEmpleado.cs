using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoTipoEmpleado
    {
        public CatalogoTipoEmpleado()
        {
            AsignacionTiposEmpleados = new HashSet<AsignacionTiposEmpleado>();
        }

        public int IdCatalogotipodeempleado { get; set; }
        public string? Tipo { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? FechaHoraUltimaModificacion { get; set; }

        public virtual ICollection<AsignacionTiposEmpleado> AsignacionTiposEmpleados { get; set; }
    }
}
