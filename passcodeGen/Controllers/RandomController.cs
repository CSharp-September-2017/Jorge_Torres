using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;

namespace passcodeGen.Controllers
{
    public class RandomController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? Count = HttpContext.Session.GetInt32("times");
            if(Count == null)
            {
                HttpContext.Session.SetInt32("times", 1);
                
            }
            else
            {
                Count++;
                HttpContext.Session.SetInt32("times", (int)Count);
                
                Random rand = new Random();
                string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string lowerCase = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "1234567890";
                string pool_word = numbers; 
                pool_word += upperCase + lowerCase;
                StringBuilder buffer = new  StringBuilder();
                for(int i =0; i<14; i++)
                {
                    int randomNum = rand.Next(0, pool_word.Length);
                    var result = buffer.Append(pool_word, randomNum, 1);
                    ViewBag.Result = result;
                }

            } 
            
            ViewBag.times = HttpContext.Session.GetInt32("times");
            return View();
        }
    }
}