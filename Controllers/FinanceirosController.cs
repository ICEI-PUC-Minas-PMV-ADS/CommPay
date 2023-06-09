﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Commpay.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Commpay.Controllers
{
    public class FinanceirosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FinanceirosController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return _context.Financeiros != null ?
                        View(await _context.Financeiros.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Financeiros'  is null.");
        }





        // GET Comissões
        public async Task<IActionResult> Comissoes()
        {
            return View(await _context.Vendas.ToListAsync());

        }


        // GET Comissões
        public async Task<IActionResult> Relatorios()
        {
            return View(await _context.Vendas.ToListAsync());

        }





        // GET: Financeiros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Financeiros == null)
            {
                return NotFound();
            }

            var financeiro = await _context.Financeiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financeiro == null)
            {
                return NotFound();
            }

            return View(financeiro);
        }

        // GET: Financeiros/Create
        public IActionResult Create()
        {
            return View();
        }

  
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Senha,Cargo")] Financeiro financeiro)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(financeiro);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(financeiro);
        //}


        //CRIAÇÃO DE USUARIOS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Senha,Cargo,Cpf")] Usuario dadoslogin)
        {
            if (ModelState.IsValid)
            {
               dadoslogin.Senha = BCrypt.Net.BCrypt.HashPassword(dadoslogin.Senha);
                _context.Add(dadoslogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

                return View(dadoslogin);
        }






        // GET: Financeiros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Financeiros == null)
            {
                return NotFound();
            }

            var financeiro = await _context.Financeiros.FindAsync(id);
            if (financeiro == null)
            {
                return NotFound();
            }
            return View(financeiro);
        }

        // POST: Financeiros/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Senha,Cargo")] Financeiro financeiro)
        {
            if (id != financeiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financeiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinanceiroExists(financeiro.Id))
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
            return View(financeiro);
        }

        // GET: Financeiros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Financeiros == null)
            {
                return NotFound();
            }

            var financeiro = await _context.Financeiros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financeiro == null)
            {
                return NotFound();
            }

            return View(financeiro);
        }

        // POST: Financeiros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Financeiros == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Financeiros'  is null.");
            }
            var financeiro = await _context.Financeiros.FindAsync(id);
            if (financeiro != null)
            {
                _context.Financeiros.Remove(financeiro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }     

        private bool FinanceiroExists(int id)
        {
          return (_context.Financeiros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
