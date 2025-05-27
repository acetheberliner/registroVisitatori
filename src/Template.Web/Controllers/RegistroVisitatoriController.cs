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

        // ✅ Mostra TUTTI i visitatori (presenti e già usciti), ordinati per ingresso decrescente
        public virtual async Task<IActionResult> Index()
        {
            var visitatori = await _context.Visitatori
                .OrderByDescending(v => v.DataIngresso)
                .ToListAsync();

            return View("~/Views/RegistroVisitatori/Index.cshtml", visitatori);
        }

        // ✅ Mostra la form di creazione nuovo visitatore
        public virtual IActionResult Crea()
        {
            return View("~/Views/RegistroVisitatori/Crea.cshtml");
        }

        // ✅ Salva un nuovo visitatore e mostra messaggio di successo
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

        // ✅ Segna l'orario di uscita di un visitatore e mostra conferma
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
