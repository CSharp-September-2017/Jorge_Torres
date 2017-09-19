using Microsoft.AspNetCore.Mvc;
 
namespace callingCard.controllers
{
    public class CardController : Controller
    {
  /*      [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            return View();
        }
*/
        [HttpGet]
        [Route("/{FirstName}/{LastName}/{Age}/{FavColor}")]
        public JsonResult Show(string fname, string lname, int Age, string fcolor)
        {
            var  person  = new 
            {
            firstName = fname,
            lastName = lname,
            Age =Age,
            favColor = fcolor
            };
            return Json(person);
        }
     
    }
}