using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Justificacione
    {
        public int IdJustificaciones { get; set; }
        public int? EmpleadoId { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Motivo { get; set; }
        public bool? Aprobada { get; set; }
        public int? NucEmpleado { get; set; }
    }
}
