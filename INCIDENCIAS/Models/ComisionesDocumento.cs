using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class ComisionesDocumento
    {
        public ComisionesDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdComisiones { get; set; }
        public string? TipoComision { get; set; }
        public int? Comisiones { get; set; }
        public int? IdDetalles { get; set; }
        public int? IdUnidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Motivo { get; set; }
        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
