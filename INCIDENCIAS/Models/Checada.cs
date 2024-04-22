using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Checada
    {
        public Checada()
        {
            Incidencia = new HashSet<Incidencia>();
        }

        public int IdChecadas { get; set; }
        public int? EmpleadoId { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? HoraEntrada { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public int? IdChecador { get; set; }
        public int? NucEmpleado { get; set; }

        public virtual Checador? IdChecadorNavigation { get; set; }
        public virtual ICollection<Incidencia> Incidencia { get; set; }
    }
}
