using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class DiasEstimuloDocumento
    {
        public int IdDiaEstimuloDocumento { get; set; }
        public string? TipoDia { get; set; }
        public bool? IndicadorDia { get; set; }
        public int? IdDetalles { get; set; }
        public int? Anio { get; set; }
        public int? IdUnidad { get; set; }
        public int? NucEmpleado { get; set; }
        public string? TipoPeriodo { get; set; }
        public string? NoRelojChecador { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual Unidade? IdUnidadNavigation { get; set; }
    }
}
