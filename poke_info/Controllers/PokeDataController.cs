using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace poke_info.Controllers
{
    public class PokeDataController : Controller
    {
        [HttpGet]
        [Route("pokeinfo/{PokeId}")]
        public IActionResult GetData(int PokeId)
        {
            var PokeObject = new Pokemon();

            WebRequest.GetPokemonDataAsync(PokeId, PokeResponse => {
                PokeObject = PokeResponse;
            }).Wait();
            ViewBag.Pokemon = PokeObject;
            return View();
        }
    }
}