using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class IncapacidadesDocumento
    {
        public IncapacidadesDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdIncapacidades { get; set; }
        public string? TipoIncapacidad { get; set; }
        public bool? IndicadorIncapacidad { get; set; }
        public int? IdDetalles { get; set; }
        public int? IdMedicos { get; set; }
        public DateTime? FInicio { get; set; }
        public DateTime? FFinal { get; set; }
        public string? Diagnosticos { get; set; }
        public int? IdUnidad { get; set; }

        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual Medico? IdMedicosNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
