using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using System.Linq;



namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
    
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/quotes")]
        public IActionResult Send(string Name, string Quote)
        {
            string Insert_query = $"Insert into quotes (name, quote, created_at, updated_at) values('{Name}', '{Quote}', NOW(), NOW());";
            DbConnector.Execute(Insert_query);

            return  RedirectToAction("Index");
        }

        [HttpGet]
        [Route("quotes")]
        public IActionResult Quotes()
        {
            string Select_query = "select * from quotes;";
        
            var records = DbConnector.Query(Select_query);

            records = records.OrderByDescending((quote) => quote["created_at"]).ToList();

            foreach(var quote in records)
            {
                DateTime created = (DateTime)quote["created_at"];
                string formatted_created = String.Format("{0:h:mm tt MMMM d yyyy}", created);
                quote["created_at"] = formatted_created;
            }
            
            ViewBag.Select = records;
            
            return View();
        }

    }

}

