using Locadora.API.Services;
using Locadora.Models;
using Locadora.Respository;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("serie")]
    public class SerieController : BibliotecaController
    {
        private GestaoServices _gestaoServices = new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarSerie([FromBody] SerieViewModel serieRecebido)
        {
            string nomeSerie = serieRecebido.Titulo;
            return Created("serie", serieRecebido);
        }
    }
}
