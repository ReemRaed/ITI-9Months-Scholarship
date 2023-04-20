using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Views.ProductHub
{
    public class ProductHubController : Controller
    {
        private readonly DBContext _context;

        public ProductHubController(DBContext context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            return _context.products != null ?
                        View(await _context.products.ToListAsync()) :
                        Problem("Entity set 'DBContext.products'  is null.");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.products == null)
            {
                return NotFound();
            }

            var product = await _context.products.Include(e => e.Comments)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }



    }
}
