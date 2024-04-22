using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class LicenciasDocumento
    {
        public LicenciasDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdLicencia { get; set; }
        public string? TipoLicencia { get; set; }
        public bool? IndicadorLicencia { get; set; }
        public int? IdDetalles { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? IdUnidad { get; set; }
        public int? NucEmpleado { get; set; }
        public int? NoRelojChecador { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual Unidade? IdUnidadNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
