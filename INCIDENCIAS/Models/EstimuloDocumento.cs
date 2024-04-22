using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class EstimuloDocumento
    {
        public EstimuloDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdEstimulo { get; set; }
        public string? TipoEstimulo { get; set; }
        public bool? IndicadorEstimulo { get; set; }
        public int? IdDetalles { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
