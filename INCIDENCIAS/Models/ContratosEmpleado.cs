using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class ContratosEmpleado
    {
        public int NucEmpleado { get; set; }
        public int FolioContrato { get; set; }
        public Guid? Verificador { get; set; }
        public string? ClaveCatalogoContratoEmpleado { get; set; }
        public string? DescripcionContratoEmpleado { get; set; }
        public DateTime? FechaContrato { get; set; }
        public DateTime? FechaEfectoInicio { get; set; }
        public DateTime? FechaEfectoFin { get; set; }
        public int? IdCatalogoPuesto { get; set; }
        public string? IdCodigoPuesto { get; set; }
        public decimal? SueldoBruto { get; set; }
        public string? CveCtroAdscripcion { get; set; }
        public string? CveCtroDistribucion { get; set; }
        public string? CveFuenteFinanciamiento { get; set; }
        public string? AcuerdoCon { get; set; }
        public string? FuncionesAcuerdo { get; set; }
        public int? NoEmpleadoVoBo { get; set; }
        public int? NoEmpleadoAutoriza1 { get; set; }
        public int? NoEmpleadoAutoriza2 { get; set; }
        public string? CccPara { get; set; }
        public string? EstatusContrato { get; set; }
        public int? JornadaEnHoras { get; set; }
        public int? IdJornada { get; set; }
        public int? IdHorario { get; set; }
        public int? ClaveClasificacionContrato { get; set; }
        public int? ClaveTipoContrato { get; set; }
        public int? CapturadoPor { get; set; }
        public int? ModificadoPor { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual CatalogoClasificacionContrato? ClaveClasificacionContratoNavigation { get; set; }
        public virtual CatalogoTiposDeContrato? ClaveTipoContratoNavigation { get; set; }
        public virtual Horario? IdHorarioNavigation { get; set; }
        public virtual Jornada? IdJornadaNavigation { get; set; }
    }
}
