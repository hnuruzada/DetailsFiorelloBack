using FiorelloBack.DAL;
using FiorelloBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FiorelloBack.Controllers
{
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        public FlowerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {
            Flower flower = _context.Flowers.Include(f=>f.Campaign).Include(f=>f.FlowerCategories).ThenInclude(fc=>fc.Category).Include(f=>f.FlowerTags).ThenInclude(ft=>ft.Tag).Include(f=>f.FlowerImages).FirstOrDefault(f=>f.Id==id);
            return View(flower);
        }
    }
}
