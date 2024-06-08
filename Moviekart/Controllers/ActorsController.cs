using Microsoft.AspNetCore.Mvc;
using Moviekart.Data;
using Moviekart.Data.Services;
using Moviekart.Models;

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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName", "ProfilePictureURL", "Bio")]Actor actor)
        {
            if (ModelState.IsValid)
            {
                _actorsService.Add(actor);
                return RedirectToAction(nameof(Index));
            }
            // Validation failed
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            return View(actor); // Pass the model back to the view with any errors

        }

        public async Task<IActionResult> Details(int id)
        {
            var details = await _actorsService.GetActorById(id);
            return View(details);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetActorById(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("ActorID","FullName", "ProfilePictureURL", "Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                await _actorsService.Update(id, actor);
                return RedirectToAction(nameof(Index));
            }
            // Validation failed
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            return View(actor); // Pass the model back to the view with any errors
        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetActorById(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorsService.GetActorById(id);
            if (actorDetails == null) return View("NotFound");

            await _actorsService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
