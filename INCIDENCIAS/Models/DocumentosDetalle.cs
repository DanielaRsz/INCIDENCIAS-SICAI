using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class DocumentosDetalle
    {
        public DocumentosDetalle()
        {
            ComisionesDocumentos = new HashSet<ComisionesDocumento>();
            ContratosDocumentos = new HashSet<ContratosDocumento>();
            DiasDocumentos = new HashSet<DiasDocumento>();
            DiasEstimuloDocumentos = new HashSet<DiasEstimuloDocumento>();
            Documentos = new HashSet<Documento>();
            EstimuloDocumentos = new HashSet<EstimuloDocumento>();
            EstimuloHorasExtras = new HashSet<EstimuloHorasExtra>();
            GuardiaDocumentos = new HashSet<GuardiaDocumento>();
            IncapacidadesDocumentos = new HashSet<IncapacidadesDocumento>();
            JustificacionDocumentos = new HashSet<JustificacionDocumento>();
            LicenciasDocumentos = new HashSet<LicenciasDocumento>();
            RetardoDocumentos = new HashSet<RetardoDocumento>();
            VacacionesDocumentos = new HashSet<VacacionesDocumento>();
        }

        public int IdDocumentosDetalle { get; set; }
        public int? IdDetalle { get; set; }
        public string? Detalles { get; set; }

        public virtual ICollection<ComisionesDocumento> ComisionesDocumentos { get; set; }
        public virtual ICollection<ContratosDocumento> ContratosDocumentos { get; set; }
        public virtual ICollection<DiasDocumento> DiasDocumentos { get; set; }
        public virtual ICollection<DiasEstimuloDocumento> DiasEstimuloDocumentos { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<EstimuloDocumento> EstimuloDocumentos { get; set; }
        public virtual ICollection<EstimuloHorasExtra> EstimuloHorasExtras { get; set; }
        public virtual ICollection<GuardiaDocumento> GuardiaDocumentos { get; set; }
        public virtual ICollection<IncapacidadesDocumento> IncapacidadesDocumentos { get; set; }
        public virtual ICollection<JustificacionDocumento> JustificacionDocumentos { get; set; }
        public virtual ICollection<LicenciasDocumento> LicenciasDocumentos { get; set; }
        public virtual ICollection<RetardoDocumento> RetardoDocumentos { get; set; }
        public virtual ICollection<VacacionesDocumento> VacacionesDocumentos { get; set; }
    }
}
