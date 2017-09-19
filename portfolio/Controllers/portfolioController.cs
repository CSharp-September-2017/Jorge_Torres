using Microsoft.AspNetCore.Mvc;

namespace portfolioController.Controllers
{
    public class portfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        [Route("projects")]

        public IActionResult Projects()
        {
            return  View();
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }


    }
}