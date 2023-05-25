using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Commpay.Models;
using Microsoft.AspNetCore.Authorization;

namespace Commpay.Controllers
{
    [Authorize (Roles = "Vendedor")]
    public class VendedoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET Comissões
        public async Task<IActionResult> Comissoes()
        {
            return View(await _context.Vendas.ToListAsync());
        }
    }
}
