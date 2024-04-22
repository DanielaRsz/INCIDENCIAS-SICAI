using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Incidencia
    {
        public int IdIncidencias { get; set; }
        public int? IdTipoEmpleado { get; set; }
        public string? Tipo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
        public int? IdChecadas { get; set; }
        public int? NucEmpleados { get; set; }

        public virtual Checada? IdChecadasNavigation { get; set; }
        public virtual AsignacionTiposEmpleado? IdTipoEmpleadoNavigation { get; set; }
    }
}
