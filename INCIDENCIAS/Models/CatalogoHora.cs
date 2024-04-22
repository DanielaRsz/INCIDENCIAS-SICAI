using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoHora
    {
        public CatalogoHora()
        {
            Horarios = new HashSet<Horario>();
        }

        public int IdHora { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? FechaHoraUltimaModificacion { get; set; }

        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
