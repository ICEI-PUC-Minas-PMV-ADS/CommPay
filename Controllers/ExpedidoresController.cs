using Commpay.Models;
using Commpay.Models.Enums;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Commpay.Controllers
{
    [Authorize (Roles = "Expedidor")]
    public class ExpedidoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpedidoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET Expedidores/Entregas
        public async Task<IActionResult> Entregas()
        {
            var entregas = await _context.Vendas.ToListAsync();
            return View(entregas);
        }


        //POST DE EDIT
        [HttpPost]
        public IActionResult Edit(int id, string entregador, Status status)
        {
            var venda = _context.Vendas.FirstOrDefault(v => v.Id == id);

            if (venda == null)
            {
                return NotFound();
            }

            venda.Entregador = entregador;
            venda.Status = status;

            _context.SaveChanges();

            return RedirectToAction("Entregas");
        }

        private bool ExpedidorExists(int id)
        {
          return (_context.Usuario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
