using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class DiasDocumento
    {
        public DiasDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdDiaDocumento { get; set; }
        public string? TipoDia { get; set; }
        public bool? IndicadorDia { get; set; }
        public int? IdDetalles { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
