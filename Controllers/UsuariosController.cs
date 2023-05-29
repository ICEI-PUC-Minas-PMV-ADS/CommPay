using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Commpay.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Authorization;

namespace Commpay.Controllers
{
    [Authorize(Roles = "Financeiro")]
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET DA PAGINA DE LOGIN
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        // POST DA PAGINA DE LOGIN
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Cpf,Senha")] Usuario dadoslogin)
        {
            var user = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Cpf == dadoslogin.Cpf);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            //COMPARA SENHAS QUE ELE ENVIOU COM A DO BANCO DE DADOS
            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(dadoslogin.Senha, user.Senha);


            if (isSenhaOk)
            {

                //CONFIGURAÇÃO DAS CREDENCIAIS
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
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(10),
                    IsPersistent = true
                };


                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            };

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();

        }


        // FAZ O LOGOUT DO SISTEMA
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuarios");
        }



        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }



        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var success = TempData["UserSuccess"];
            ViewBag.Sucesso = success;

            return View(await _context.Usuario.ToListAsync());
        }




        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Senha,Cargo")] Usuario usuario)
        {
            var confereCPF = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Cpf == usuario.Cpf);

            if (confereCPF != null)
            {
                ViewBag.cpfExiste = true;
            }
            else if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                TempData["UserSuccess"] = "Usuário Cadastrado com Sucesso!";
                return RedirectToAction("Index", new { success = "Usuário Cadastrado com Sucesso!" });
            }

            return RedirectToAction("Index");
        }





        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Senha,Cargo")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
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

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return (_context.Usuario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
