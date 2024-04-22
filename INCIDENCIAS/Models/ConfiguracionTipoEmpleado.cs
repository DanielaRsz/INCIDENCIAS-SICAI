using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class ConfiguracionTipoEmpleado
    {
        public ConfiguracionTipoEmpleado()
        {
            AsignacionTiposEmpleados = new HashSet<AsignacionTiposEmpleado>();
        }

        public int IdConfTipoEmpleado { get; set; }
        public string? Dato { get; set; }
        public int? Baja { get; set; }
        public int? ToleranciaRetardoMayor { get; set; }
        public int? ToleranciaRetardoMenor { get; set; }
        public int? EsFaltaOmision { get; set; }
        public int? RetardosMayoresJustificables { get; set; }
        public int? DerechoPasesSalida { get; set; }
        public int? TiempoTotalPasesSalida { get; set; }
        public int? TiempoMaximoPorPase { get; set; }
        public int? DerechoDiasEconomicos { get; set; }
        public int? DiasEconomicosAlAnio { get; set; }
        public int? DiasEconomicosConsecutivos { get; set; }
        public int? DiasEconomicosAfectaEstimulos { get; set; }
        public int? DerechoHorarioGuarderia { get; set; }
        public int? HorasHorarioGuarderia { get; set; }
        public int? TiempoHorarioGuarderia { get; set; }
        public int? DerechoPermisoLactancia { get; set; }
        public int? HorasPermisoLactancia { get; set; }
        public int? TiempoHorarioLactancia { get; set; }
        public int? DerechoHorarioEstudiantil { get; set; }
        public int? DiasEconomicosAlMes { get; set; }
        public int? NumeroMaximoDePases { get; set; }
        public int? AnioNatural { get; set; }
        public byte[]? FechaHoraUltimaModificacion { get; set; }
        public int? NucEmpleado { get; set; }

        public virtual ICollection<AsignacionTiposEmpleado> AsignacionTiposEmpleados { get; set; }
    }
}
