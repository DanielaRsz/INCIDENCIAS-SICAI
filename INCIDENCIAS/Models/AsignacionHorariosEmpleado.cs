using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class AsignacionHorariosEmpleado
    {
        public int IdAsignacion { get; set; }
        public int IdTipoEmpleado { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdHorario { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual Horario? IdHorarioNavigation { get; set; }
    }
}
