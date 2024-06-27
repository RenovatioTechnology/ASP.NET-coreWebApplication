using coreRTWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreRTWebApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDBContext _context; // Replace YourDbContext with your actual DbContext

        public ShopController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var shopItems = _context.ShopItems.ToList(); // Fetch shop items from the database
            return View(shopItems);
        }

        public IActionResult Details(int id)
        {
            var shopItem = _context.ShopItems.Find(id); // Fetch a specific shop item from the database
            if (shopItem == null)
            {
                return NotFound();
            }
            return View(shopItem);
        }

        // Add more actions as needed, such as Create, Edit, Delete, etc.
    }
}
