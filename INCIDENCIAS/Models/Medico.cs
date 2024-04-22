using System;
using System.Collections.Generic;

namespace INCiDENCIAS.Models
{
    public partial class Medico
    {
        public Medico()
        {
            IncapacidadesDocumentos = new HashSet<IncapacidadesDocumento>();
        }

        public int IdMedicos { get; set; }
        public string? Especialidad { get; set; }

        public virtual ICollection<IncapacidadesDocumento> IncapacidadesDocumentos { get; set; }
    }
}
