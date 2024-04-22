using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class RetardoDocumento
    {
        public RetardoDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdRetardo { get; set; }
        public string? TipoRetardo { get; set; }
        public bool? IndicadorRetardo { get; set; }
        public int? IdDetalles { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
