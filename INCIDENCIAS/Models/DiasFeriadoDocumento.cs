using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class DiasFeriadoDocumento
    {
        public int IdDiaFeriado { get; set; }
        public DateTime? FTrabaja { get; set; }
        public DateTime? FAutoriza { get; set; }
        public string? Motivo { get; set; }
        public int? NucEmpleado { get; set; }
        public string? NoRelojChecador { get; set; }
        public int? IdDetalles { get; set; }
        public int? IdUnidad { get; set; }
    }
}
