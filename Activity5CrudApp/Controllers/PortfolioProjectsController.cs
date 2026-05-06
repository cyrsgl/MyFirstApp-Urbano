using Activity4FrontendApp.Data;
using Activity4FrontendApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Activity4FrontendApp.Controllers
{
    public class PortfolioProjectsController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioProjectsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.PortfolioProjects.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PortfolioProject project)
        {
            if (ModelState.IsValid)
            {
                _context.PortfolioProjects.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(project);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var project = await _context.PortfolioProjects.FindAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PortfolioProject project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.PortfolioProjects.Update(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(project);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var project = await _context.PortfolioProjects.FindAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.PortfolioProjects.FindAsync(id);

            if (project != null)
            {
                _context.PortfolioProjects.Remove(project);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}