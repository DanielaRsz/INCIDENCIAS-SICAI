using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Unidade
    {
        public Unidade()
        {
            DiasEstimuloDocumentos = new HashSet<DiasEstimuloDocumento>();
            EstimuloHorasExtras = new HashSet<EstimuloHorasExtra>();
            LicenciasDocumentos = new HashSet<LicenciasDocumento>();
        }

        public int IdUnidad { get; set; }
        public string? NombreUnidad { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Clues { get; set; }
        public string? ClaveCentro { get; set; }

        public virtual ICollection<DiasEstimuloDocumento> DiasEstimuloDocumentos { get; set; }
        public virtual ICollection<EstimuloHorasExtra> EstimuloHorasExtras { get; set; }
        public virtual ICollection<LicenciasDocumento> LicenciasDocumentos { get; set; }
    }
}
