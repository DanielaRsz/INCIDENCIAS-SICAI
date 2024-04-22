using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoJornada
    {
        public CatalogoJornada()
        {
            Jornada = new HashSet<Jornada>();
        }

        public int IdCatalogosjornadas { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public int? IdEstatus { get; set; }

        public virtual Estatus? IdEstatusNavigation { get; set; }
        public virtual ICollection<Jornada> Jornada { get; set; }
    }
}
