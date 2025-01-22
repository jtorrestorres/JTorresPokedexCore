using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Add([FromBody] ML.Result result)
        {
            return View();
        }


    }
}
