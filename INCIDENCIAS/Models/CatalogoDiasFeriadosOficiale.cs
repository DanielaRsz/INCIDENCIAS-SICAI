using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoDiasFeriadosOficiale
    {
        public int IdDiaFeriado { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Descripcion { get; set; }
        public byte[] FechaHoraUltimaModificacion { get; set; } = null!;
    }
}
