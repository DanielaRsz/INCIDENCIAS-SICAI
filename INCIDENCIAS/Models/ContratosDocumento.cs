using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class ContratosDocumento
    {
        public int IdTipoContrato { get; set; }
        public int IdDocumento { get; set; }
        public bool? Aplica { get; set; }
        public int? IdDetalles { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual Documento IdDocumentoNavigation { get; set; } = null!;
        public virtual CatalogoTiposDeContrato IdTipoContratoNavigation { get; set; } = null!;
    }
}
