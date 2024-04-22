using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoHorario
    {
        public CatalogoHorario()
        {
            Horarios = new HashSet<Horario>();
        }

        public int IdCatalogoHorario { get; set; }
        public string? DescripcionHorario { get; set; }
        public string? DiasLaborables { get; set; }
        public string? Horario1 { get; set; }
        public string? Horario2 { get; set; }
        public byte[]? FechaHoraUltimaModificacion { get; set; }
        public int? IdEstatus { get; set; }

        public virtual Estatus? IdEstatusNavigation { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
