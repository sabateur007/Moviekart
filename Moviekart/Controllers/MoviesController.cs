using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moviekart.Data;
using Moviekart.Data.Services;

namespace Moviekart.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service) 
        {
            _service = service;
        }   
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAll();
            return View(allMovies);
        }
    }
}
