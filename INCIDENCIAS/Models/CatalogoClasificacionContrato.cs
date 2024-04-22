using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoClasificacionContrato
    {
        public CatalogoClasificacionContrato()
        {
            ContratosEmpleados = new HashSet<ContratosEmpleado>();
        }

        public int IdClasificacionContrato { get; set; }
        public string? ClasificacionContrato { get; set; }
        public int? IdEstatus { get; set; }

        public virtual Estatus? IdEstatusNavigation { get; set; }
        public virtual ICollection<ContratosEmpleado> ContratosEmpleados { get; set; }
    }
}
