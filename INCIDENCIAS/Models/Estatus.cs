using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Estatus
    {
        public Estatus()
        {
            CatalogoClasificacionContratos = new HashSet<CatalogoClasificacionContrato>();
            CatalogoHorarios = new HashSet<CatalogoHorario>();
            CatalogoJornada = new HashSet<CatalogoJornada>();
            CatalogoTiposDeContratos = new HashSet<CatalogoTiposDeContrato>();
            Checadors = new HashSet<Checador>();
            Horarios = new HashSet<Horario>();
        }

        public int IdEstatus { get; set; }
        public string? NombreEstado { get; set; }

        public virtual ICollection<CatalogoClasificacionContrato> CatalogoClasificacionContratos { get; set; }
        public virtual ICollection<CatalogoHorario> CatalogoHorarios { get; set; }
        public virtual ICollection<CatalogoJornada> CatalogoJornada { get; set; }
        public virtual ICollection<CatalogoTiposDeContrato> CatalogoTiposDeContratos { get; set; }
        public virtual ICollection<Checador> Checadors { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
