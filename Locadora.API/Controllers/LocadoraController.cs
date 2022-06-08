using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("locadora")]
    public class LocadoraController : Controller
    {
        [HttpGet]
        public IActionResult Inicio()
        {
            return Ok("Teste");
        }
    }
}
