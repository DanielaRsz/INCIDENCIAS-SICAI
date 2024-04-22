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
    public class IncapacidadesModel : PageModel
    {
        private readonly INCiDENCIAS.Models.INCIDENCIAS1Context _context;

        public IncapacidadesModel(INCiDENCIAS.Models.INCIDENCIAS1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IdDetalles"] = new SelectList(_context.DocumentosDetalles, "IdDocumentosDetalle", "IdDocumentosDetalle");
            return Page();
        }

        public List<Unidade> Unidades { get; set; }

        public async Task OnGetAsync()
        {
            Unidades = await _context.Unidades.ToListAsync();
            ViewData["Empleados"] = ObtenerListaEmpleados();
        }

        // Método para obtener la lista de empleados
        private List<AsignacionTiposEmpleado> ObtenerListaEmpleados()
        {
            // Asegurémonos de que _context.AsignacionTiposEmpleado no es null
            if (_context.AsignacionTiposEmpleados != null)
            {
                // Intentemos obtener la lista de empleados utilizando Entity Framework Core
                try
                {
                    // Utilicemos ToList() para convertir el IQueryable a una lista
                    return _context.AsignacionTiposEmpleados.ToList();
                }
                catch (Exception ex)
                {
                    // Si hay un error, registremos el error y devolvamos una lista vacía
                    Console.WriteLine("Error al obtener la lista de empleados: " + ex.Message);
                    return new List<AsignacionTiposEmpleado>();
                }
            }
            else
            {
                // Si _context.AsignacionTiposEmpleado es null, devolvamos una lista vacía
                return new List<AsignacionTiposEmpleado>();
            }
        }

        [BindProperty]
        public IncapacidadesDocumento IncapacidadesDocumento { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.IncapacidadesDocumentos == null || IncapacidadesDocumento == null)
            {
                return Page();
            }

            _context.IncapacidadesDocumentos.Add(IncapacidadesDocumento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
