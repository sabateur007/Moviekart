using Microsoft.AspNetCore.Mvc;
using Moviekart.Data;
using Moviekart.Data.Services;

namespace Moviekart.Controllers
{
    public class ActorsController : Controller
    {
        IActorsService _actorsService;
        public ActorsController( IActorsService actorsService)
        {
            
            _actorsService = actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var data  = await _actorsService.GetAllActors();
            return View(data);
        }
    }
}
