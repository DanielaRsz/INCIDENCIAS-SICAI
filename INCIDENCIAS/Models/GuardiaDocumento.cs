using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class GuardiaDocumento
    {
        public GuardiaDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdGuardia { get; set; }
        public string? TipoGuardia { get; set; }
        public bool? IndicadorGuardia { get; set; }
        public int? IdDetalles { get; set; }
        public DateTime? Fecha { get; set; }
        public string? NoRelojChecador { get; set; }
        public string? Motivo { get; set; }
        public int? EmpleadoAcubrirId { get; set; }
        public int? EmpleadoSustitutoId { get; set; }
        public int? IdUnidad { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
