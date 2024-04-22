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
    public class DiasEstimuloModel : PageModel
    {
        private readonly INCiDENCIAS.Models.INCIDENCIAS1Context _context;

        public DiasEstimuloModel(INCiDENCIAS.Models.INCIDENCIAS1Context context)
        {
            _context = context;
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
            // Asegurémonos de que _context.AsignacionTiposEmpleados no es null
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
        public DiasEstimuloDocumento DiasEstimuloDocumento { get; set; } = default!;

        // Método para procesar el formulario cuando se envía
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.DiasEstimuloDocumentos == null || DiasEstimuloDocumento == null)
            {
                return Page();
            }

            _context.DiasEstimuloDocumentos.Add(DiasEstimuloDocumento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
