using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoIncidenciasColore
    {
        public int IdIncidenciasColores { get; set; }
        public byte? Codigo { get; set; }
        public string? Dato { get; set; }
        public string? Color { get; set; }
        public byte[] FechaHoraUltimaModificacion { get; set; } = null!;
    }
}
