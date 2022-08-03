using eTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _service.GetAll();
            return View(actors);
        }

        [HttpPost]
        public IActionResult Create(string id)
        {
            if(string.IsNullOrWhiteSpace(id))
            {
                ModelState.AddModelError(string.Empty, "Id cannot be empty");
            }

            //call the create service

            ViewBag.Title = "Create New Actor";
            return View();
        }
    }
}
