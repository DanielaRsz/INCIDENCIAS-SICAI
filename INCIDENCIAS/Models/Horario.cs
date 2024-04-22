using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Horario
    {
        public Horario()
        {
            AsignacionHorariosEmpleados = new HashSet<AsignacionHorariosEmpleado>();
            ContratosEmpleados = new HashSet<ContratosEmpleado>();
            Jornada = new HashSet<Jornada>();
        }

        public int IdHorario { get; set; }
        public int? IdEstatus { get; set; }
        public int? IdCatalogoHorario { get; set; }
        public int? IdHora { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? NucEmpleados { get; set; }

        public virtual CatalogoHorario? IdCatalogoHorarioNavigation { get; set; }
        public virtual Estatus? IdEstatusNavigation { get; set; }
        public virtual CatalogoHora? IdHoraNavigation { get; set; }
        public virtual ICollection<AsignacionHorariosEmpleado> AsignacionHorariosEmpleados { get; set; }
        public virtual ICollection<ContratosEmpleado> ContratosEmpleados { get; set; }
        public virtual ICollection<Jornada> Jornada { get; set; }
    }
}
