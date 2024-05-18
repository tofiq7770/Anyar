using AnyarMVC.DAL;
using AnyarMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnyarMVC.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class PositionController : Controller
    {
        private readonly AppDbContext _context;
        public PositionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Position> positions = _context.Positions.ToList();
            return View(positions);
        }
    }
}
