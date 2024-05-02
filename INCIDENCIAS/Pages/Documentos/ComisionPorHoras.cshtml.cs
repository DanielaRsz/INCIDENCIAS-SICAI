using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using INCiDENCIAS.Models;
using Microsoft.EntityFrameworkCore;

namespace INCiDENCIAS.Pages.Documentos
{
    public class ComisionPorHorasModel : PageModel
    {
        private readonly INCiDENCIAS.Models.INCIDENCIAS1Context _context;

        public ComisionPorHorasModel(INCiDENCIAS.Models.INCIDENCIAS1Context context)
        {
            _context = context;
        }

        public SelectList UnidadesSelectList { get; set; }
        public List<Unidade> Unidades { get; set; } // Esta es la propiedad que necesitas inicializar

        public async Task<PageResult> OnGetAsync()
        {
            // Obtener la lista de unidades y crear el SelectList
            Unidades = await _context.Unidades.ToListAsync();
            UnidadesSelectList = new SelectList(Unidades, "IdUnidad", "NombreUnidad");
            ViewData["IdDetalles"] = new SelectList(_context.DocumentosDetalles, "IdDocumentosDetalle", "IdDocumentosDetalle");
            return Page();
        }

        [BindProperty]
        public ComisionesDocumento ComisionesDocumento { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.ComisionesDocumentos == null || ComisionesDocumento == null)
            {
                return Page();
            }

            _context.ComisionesDocumentos.Add(ComisionesDocumento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
