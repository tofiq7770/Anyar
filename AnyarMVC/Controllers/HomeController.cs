using AnyarMVC.DAL;
using AnyarMVC.Models;
using AnyarMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnyarMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Position> positions = await _context.Positions.ToListAsync();
            List<Team> teams = await _context.Teams.ToListAsync();
            HomeVM model = new()
            {
                Positions = positions,
                Teams = teams
            };
            return View(model);
        }
    }
}
