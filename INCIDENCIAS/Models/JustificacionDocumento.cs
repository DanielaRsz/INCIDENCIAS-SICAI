using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class JustificacionDocumento
    {
        public JustificacionDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdJustificacion { get; set; }
        public string? TipoJustificacion { get; set; }
        public bool? IndicadorJustificacion { get; set; }
        public int? IdDetalles { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdUnidad { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
