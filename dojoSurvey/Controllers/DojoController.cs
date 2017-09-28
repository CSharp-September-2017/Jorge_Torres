using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace dojoSurvey.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("show")]
        public IActionResult Show(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View();
        }


    }
}