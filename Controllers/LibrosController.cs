using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class LibrosController : Controller
    {
        private readonly AppDbContext _context;

        public LibrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Libros
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Libros.Include(l => l.Autor).Include(l => l.Editorial).Include(l => l.Genero);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Libros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Libros == null)
            {
                return NotFound();
            }

            var libros = await _context.Libros
                .Include(l => l.Autor)
                .Include(l => l.Editorial)
                .Include(l => l.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (libros == null)
            {
                return NotFound();
            }

            return View(libros);
        }

        // GET: Libros/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Autores= await _context.Autores.ToListAsync();
            ViewBag.Editoriales= await _context.Editoriales.ToListAsync();
            ViewBag.Generos = await _context.Generos.ToListAsync();
            return View();
        }

        // POST: Libros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Existencias_Libro,Precio_Libro,Descripcion_Libro,AutorId,EditorialId,GeneroId")] Libros libros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(libros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nacionalidad", libros.AutorId);
            ViewData["EditorialId"] = new SelectList(_context.Editoriales, "Id", "Contacto", libros.EditorialId);
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Descripcion_Genero", libros.GeneroId);
            return View(libros);
        }

        // GET: Libros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Libros == null)
            {
                return NotFound();
            }

            var libros = await _context.Libros.FindAsync(id);
            if (libros == null)
            {
                return NotFound();
            }
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nombre", libros.AutorId);
            ViewData["EditorialId"] = new SelectList(_context.Editoriales, "Id", "Nombre", libros.EditorialId);
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Nombre", libros.GeneroId);
            return View(libros);
        }

        // POST: Libros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Existencias_Libro,Precio_Libro,Descripcion_Libro,AutorId,EditorialId,GeneroId")] Libros libros)
        {
            if (id != libros.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(libros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibrosExists(libros.Id))
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
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nombre", libros.AutorId);
            ViewData["EditorialId"] = new SelectList(_context.Editoriales, "Id", "Nombre", libros.EditorialId);
            ViewData["GeneroId"] = new SelectList(_context.Generos, "Id", "Nombre", libros.GeneroId);
            return View(libros);
        }

        // GET: Libros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Libros == null)
            {
                return NotFound();
            }

            var libros = await _context.Libros
                .Include(l => l.Autor)
                .Include(l => l.Editorial)
                .Include(l => l.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (libros == null)
            {
                return NotFound();
            }

            return View(libros);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Libros == null)
            {
                return Problem("Entity set 'AppDbContext.Libros'  is null.");
            }
            var libros = await _context.Libros.FindAsync(id);
            if (libros != null)
            {
                _context.Libros.Remove(libros);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibrosExists(int id)
        {
          return (_context.Libros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
