using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moviekart.Data;
using Moviekart.Data.Services;

namespace Moviekart.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var AllCinemas = await _service.GetAll();    
            return View(AllCinemas);
        }
    }
}
