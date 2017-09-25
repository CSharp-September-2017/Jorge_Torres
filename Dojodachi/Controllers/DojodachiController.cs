using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace Dojodachi.Controllers
{
    public class DojodachiController : Controller
    {
        Random rand = new Random();

        [HttpGet]
        [Route("")]

        public IActionResult Index()
        {
            int? Count = HttpContext.Session.GetInt32("fullness");
            if(Count == null)
            {
                HttpContext.Session.SetInt32("fullness", 20);
                HttpContext.Session.SetInt32("happines", 20);
                HttpContext.Session.SetInt32("meals", 3);
                HttpContext.Session.SetInt32("energy", 50);
            }
        
            ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.Happines = HttpContext.Session.GetInt32("happines");
            ViewBag.Meals = HttpContext.Session.GetInt32("meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("energy");
            return View();
        }
        
        [HttpGet]
        [Route("feed")]
        public IActionResult Feed()
        {
            if(live() != true){
  
            var Meals = HttpContext.Session.GetInt32("meals");
            Meals -= 1;
            HttpContext.Session.SetInt32("meals", (int)Meals);
            
            var Fullness = HttpContext.Session.GetInt32("fullness");
            if(Fullness !=0)
            {
                Fullness += rand.Next(5, 10);
                HttpContext.Session.SetInt32("fullness", (int)Fullness);
            }

            
            }    
            
            return RedirectToAction("Index");
        }
        
        
        [HttpGet]
        [Route("play")]
        public IActionResult Play()
        {
            if(live() != true){
            var Energy =  HttpContext.Session.GetInt32("energy");
            Energy -= 5;
            HttpContext.Session.SetInt32("energy", (int)Energy);

            var Happines = HttpContext.Session.GetInt32("happines");
            Happines += rand.Next(5, 10);
            HttpContext.Session.SetInt32("happines", (int)Happines);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("work")]
        public IActionResult Work()
        {
            if(live() != true){
            var Energy =  HttpContext.Session.GetInt32("energy");
            Energy -= 5;
            HttpContext.Session.SetInt32("energy", (int)Energy);
            
            var Meals = HttpContext.Session.GetInt32("meals");
            Meals += rand.Next(1, 3);
            HttpContext.Session.SetInt32("meals", (int)Meals);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("sleep")]
        public IActionResult Sleep()
        {
            if(live() != true){
            var Energy = HttpContext.Session.GetInt32("energy");
            Energy += 15;
            HttpContext.Session.SetInt32("energy", (int)Energy);

            var Fullness = HttpContext.Session.GetInt32("fullness");
            Fullness -=5;
            HttpContext.Session.SetInt32("fullness", (int)Fullness);

            var Happines = HttpContext.Session.GetInt32("happines");
            Happines -=5;
            HttpContext.Session.SetInt32("happines", (int)Happines);
            }
            return RedirectToAction("Index");
        } 
        public bool  live(){
            var Energy = HttpContext.Session.GetInt32("energy");
            var Fullness = HttpContext.Session.GetInt32("fullness");
            var Happines = HttpContext.Session.GetInt32("happines");
            var Meals = HttpContext.Session.GetInt32("meals");
            if( Fullness > 99 && Energy > 99 && Happines > 99)
            {
               string win = "You win! ;)";
               ViewBag.Win = win;
               return true;
            }
            if(Fullness < 1 || Energy < 1 || Happines < 1)
            {
                String lose = "You lose :(";
                ViewBag.Lose = lose;
            }
            return false;
        }
        



    } //DojodachiController
}