using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class CatalogoDia
    {
        public int IdCatalogodias { get; set; }
        public string? NombreDia { get; set; }
        public string? Dato { get; set; }
        public int? Baja { get; set; }
        public byte[]? FechaHoraUltimaModificacion { get; set; }
    }
}
