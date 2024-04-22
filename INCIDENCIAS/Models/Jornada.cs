using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Jornada
    {
        public Jornada()
        {
            ContratosEmpleados = new HashSet<ContratosEmpleado>();
        }

        public int IdJornada { get; set; }
        public int? IdCatalogosjornadas { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdHorarios { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? NucEmpleados { get; set; }

        public virtual CatalogoJornada? IdCatalogosjornadasNavigation { get; set; }
        public virtual Horario? IdHorariosNavigation { get; set; }
        public virtual ICollection<ContratosEmpleado> ContratosEmpleados { get; set; }
    }
}
