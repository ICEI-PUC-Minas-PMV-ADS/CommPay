using Commpay.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Commpay.Controllers
{
    public class ExpedidoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpedidoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Nome,Senha")]Usuario dadoslogin)
        {
            var user = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Nome == dadoslogin.Nome);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(dadoslogin.Senha, user.Senha);

            if (isSenhaOk) 
            {
                var claims = new List<Claim>
                {
                        new Claim(ClaimTypes.Name, user.Nome),
                        new Claim(ClaimTypes.NameIdentifier, user.Nome),
                        new Claim(ClaimTypes.Role, user.Cargo.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };


                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            };

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();

        }



        public IActionResult AcessDenied()
        {
            return View();
        }













        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Usuario.ToListAsync();
            return View(usuarios);
        }


        // GET: Expedidores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Expedidores == null)
            {
                return NotFound();
            }

            var expedidor = await _context.Expedidores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expedidor == null)
            {
                return NotFound();
            }

            return View(expedidor);
        }

        // GET: Expedidores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Expedidores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Senha,Cargo")] Expedidor expedidor)
        {
            if (ModelState.IsValid)
            {
                expedidor.Senha = BCrypt.Net.BCrypt.HashPassword(expedidor.Senha);
                _context.Add(expedidor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expedidor);
        }

        // GET: Expedidores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var expedidor = await _context.Expedidores.FindAsync(id);
            if (expedidor == null)
            {
                return NotFound();
            }
            return View(expedidor);
        }

        // POST: Expedidores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Senha,Cargo")] Expedidor expedidor)
        {
            if (id != expedidor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    expedidor.Senha = BCrypt.Net.BCrypt.HashPassword(expedidor.Senha);
                    _context.Update(expedidor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpedidorExists(expedidor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(expedidor);
        }

        // GET: Expedidores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Expedidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Expedidores'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpedidorExists(int id)
        {
          return (_context.Usuario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
