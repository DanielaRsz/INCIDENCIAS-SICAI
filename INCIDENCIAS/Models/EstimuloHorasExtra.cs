using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class EstimuloHorasExtra
    {
        public int IdEstimuloHorasEx { get; set; }
        public int? Horas { get; set; }
        public string? TipoPago { get; set; }
        public DateTime? FInicicio { get; set; }
        public DateTime? FFin { get; set; }
        public string? Motivo { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdDetalle { get; set; }
        public int? IdDetalles { get; set; }

        public virtual DocumentosDetalle? IdDetalleNavigation { get; set; }
        public virtual Unidade? IdUnidadNavigation { get; set; }
    }
}
