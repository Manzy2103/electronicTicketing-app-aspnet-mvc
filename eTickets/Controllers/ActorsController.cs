using eTickets.Data;
using eTickets.Data.Services;
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
            IEnumerable<Models.Actor>? data = await _service.GetAll();
            return View(data);
        }
        public IActionResult Create(string id)
        {
            if(id == null || id.Equals(string.Empty))
            {
                ViewBag.Title = "Create New Actor";
            }
            return View();
        }
    }
}
