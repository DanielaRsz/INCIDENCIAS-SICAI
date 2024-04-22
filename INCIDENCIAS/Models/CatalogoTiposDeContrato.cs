using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoTiposDeContrato
    {
        public CatalogoTiposDeContrato()
        {
            ContratosDocumentos = new HashSet<ContratosDocumento>();
            ContratosEmpleados = new HashSet<ContratosEmpleado>();
        }

        public int IdTipoContrato { get; set; }
        public string? DescripcionTipoContrato { get; set; }
        public string? DbLegado { get; set; }
        public string? FuenteFinanciamiento { get; set; }
        public int? IdEstatus { get; set; }

        public virtual Estatus? IdEstatusNavigation { get; set; }
        public virtual ICollection<ContratosDocumento> ContratosDocumentos { get; set; }
        public virtual ICollection<ContratosEmpleado> ContratosEmpleados { get; set; }
    }
}
