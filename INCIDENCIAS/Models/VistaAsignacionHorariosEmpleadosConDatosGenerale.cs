using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class VistaAsignacionHorariosEmpleadosConDatosGenerale
    {
        public int IdAsignacion { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdHorario { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int NucEmpleado { get; set; }
        public string? NombresEmpleado { get; set; }
        public string? ApellidoPaternoEmpleado { get; set; }
        public string? ApellidoMaternoEmpleado { get; set; }
    }
}
