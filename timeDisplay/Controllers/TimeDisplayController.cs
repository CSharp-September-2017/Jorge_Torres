using Microsoft.AspNetCore.Mvc;

namespace TimeDisplayController.Controllers
{
    public class TimeDisplayController : Controller
    {

        /*public timeDisplay()
        {
        }*/
           
            [HttpGet]
            [Route("")]
            public IActionResult Index()
            {
                return View();
            }
        



    }



}