using Microsoft.AspNetCore.Mvc;
using Moviekart.Data;

namespace Moviekart.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context) 
        {
            _context = context;
        }   
        public IActionResult Index()
        {
            return View();
        }
    }
}
