using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using INCiDENCIAS.Models;

namespace INCiDENCIAS.Pages.Documentos
{
    public class DiaEconomicoModel : PageModel
    {
        private readonly INCiDENCIAS.Models.INCIDENCIAS1Context _context;

        public DiaEconomicoModel(INCiDENCIAS.Models.INCIDENCIAS1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IdDetalles"] = new SelectList(_context.DocumentosDetalles, "IdDocumentosDetalle", "IdDocumentosDetalle");
            return Page();
        }

        [BindProperty]
        public DiasDocumento DiasDocumento { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DiasDocumentos == null || DiasDocumento == null)
            {
                return Page();
            }

            _context.DiasDocumentos.Add(DiasDocumento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
