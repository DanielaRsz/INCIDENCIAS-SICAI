using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class VacacionesDocumento
    {
        public VacacionesDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdVacaciones { get; set; }
        public string? TipoVacaciones { get; set; }
        public bool? IndicadorVacaciones { get; set; }
        public int? IdDetalles { get; set; }
        public int? IdEmpleados { get; set; }
        public string? NumeroChecador { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? Anio { get; set; }
        public int? IdUnidad { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
