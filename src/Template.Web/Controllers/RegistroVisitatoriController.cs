using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template.Web.Data;
using Template.Web.Models;

namespace Template.Web.Controllers
{
    public partial class RegistroVisitatoriController : Controller

    {
        private readonly AppDbContext _context;

        public RegistroVisitatoriController(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<IActionResult> Index()
        {
            var presenti = await _context.Visitatori
                .Where(v => v.DataUscita == null)
                .ToListAsync();

            return View("~/Views/RegistroVisitatori/Index.cshtml", presenti);
        }

        public virtual IActionResult Crea()
        {
            return View("~/Views/RegistroVisitatori/Crea.cshtml");
        }

        [HttpPost]
        public virtual async Task<IActionResult> Crea(Visitatore visitatore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitatore);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Visitatore registrato con successo!";

                return RedirectToAction(nameof(Index));
            }

            return View(visitatore);
        }

        [HttpPost]
        public virtual async Task<IActionResult> SegnaUscita(int id)
        {
            var visitatore = await _context.Visitatori.FindAsync(id);
            if (visitatore == null)
                return NotFound();

            visitatore.DataUscita = DateTime.Now;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Uscita registrata correttamente!";

            return RedirectToAction(nameof(Index));
        }
    }
}
