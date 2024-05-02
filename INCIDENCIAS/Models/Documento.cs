using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Documento
    {
        public Documento()
        {
            ContratosDocumentos = new HashSet<ContratosDocumento>();
        }

        public int IdDocumento { get; set; }
        public string? NombreDocumento { get; set; }
        public string? DetalleDocuemnto { get; set; }
        public bool? AutorizacionTrabajar { get; set; }
        public bool? ToleranciaEntrada { get; set; }
        public bool? SolicitudHorasExtras { get; set; }
        public bool? PaseSalida { get; set; }
        public bool? SancionesAdministrativas { get; set; }
        public bool? Guarderia { get; set; }
        public bool? Lactancia { get; set; }
        public bool? HorasConcedidasMasiva { get; set; }
        public int? IdRetardo { get; set; }
        public int? IdComisiones { get; set; }
        public int? IdEstimulo { get; set; }
        public int? IdJustificacion { get; set; }
        public int? IdDiasDocumentos { get; set; }
        public int? IdIncapacidades { get; set; }
        public int? IdLicencias { get; set; }
        public int? IdVacaciones { get; set; }
        public int? IdGuardia { get; set; }
        public int? IdDetalles { get; set; }
        public int? NucEmpleado { get; set; }
        public int? IdDiaFeriado { get; set; }
        public DateTime? Fecha { get; set; }
        public string? HoraInicio { get; set; }
        public string? HoraFin { get; set; }
        public int? IdUnidad { get; set; }
        public string? Motivo { get; set; }
        public bool? InicioDiaSiguiente { get; set; }
        public virtual ComisionesDocumento? IdComisionesNavigation { get; set; }
        public virtual DocumentosDetalle? IdDetallesNavigation { get; set; }
        public virtual DiasDocumento? IdDiasDocumentosNavigation { get; set; }
        public virtual EstimuloDocumento? IdEstimuloNavigation { get; set; }
        public virtual GuardiaDocumento? IdGuardiaNavigation { get; set; }
        public virtual IncapacidadesDocumento? IdIncapacidadesNavigation { get; set; }
        public virtual JustificacionDocumento? IdJustificacionNavigation { get; set; }
        public virtual LicenciasDocumento? IdLicenciasNavigation { get; set; }
        public virtual RetardoDocumento? IdRetardoNavigation { get; set; }
        public virtual VacacionesDocumento? IdVacacionesNavigation { get; set; }
        public virtual ICollection<ContratosDocumento> ContratosDocumentos { get; set; }
    }
}
