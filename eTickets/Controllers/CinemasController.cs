using eTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemasService;

        public CinemasController(ICinemasService cinemasService)
        {
            _cinemasService = cinemasService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _cinemasService.GetAllAsync();
            return View(response.Result);
        }
    }
}
