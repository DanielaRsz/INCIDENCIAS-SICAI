using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using INCiDENCIAS.Models;
using Microsoft.EntityFrameworkCore;

namespace INCiDENCIAS.Pages.Documentos
{
    public class VacacionesModel : PageModel
    {
        private readonly INCiDENCIAS.Models.INCIDENCIAS1Context _context;

        public VacacionesModel(INCiDENCIAS.Models.INCIDENCIAS1Context context)
        {
            _context = context;
        }

        public SelectList UnidadesSelectList { get; set; }
        public List<Unidade> Unidades { get; set; } // Esta es la propiedad que necesitas inicializar

        public async Task OnGetAsync()
        {
            // Obtener la lista de unidades y crear el SelectList
            Unidades = await _context.Unidades.ToListAsync();
            UnidadesSelectList = new SelectList(Unidades, "IdUnidad", "NombreUnidad");
        }

        [BindProperty]
        public VacacionesDocumento VacacionesDocumento { get; set; } = new VacacionesDocumento
        {
            IdUnidad = 0,
            NumeroChecador = "",
            FechaInicio = DateTime.Now,
            FechaFin = DateTime.Now,
            Anio = DateTime.Now.Year
        };

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.VacacionesDocumentos == null || VacacionesDocumento == null)
            {
                return Page();
            }

            _context.VacacionesDocumentos.Add(VacacionesDocumento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
