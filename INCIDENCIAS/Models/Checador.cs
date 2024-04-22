using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Checador
    {
        public Checador()
        {
            Checada = new HashSet<Checada>();
        }

        public int IdChecador { get; set; }
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }
        public string? Descripcion { get; set; }
        public int? IdEstatus { get; set; }
        public int? NucEmpleados { get; set; }

        public virtual Estatus? IdEstatusNavigation { get; set; }
        public virtual ICollection<Checada> Checada { get; set; }
    }
}
