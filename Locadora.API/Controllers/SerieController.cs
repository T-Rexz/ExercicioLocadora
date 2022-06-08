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
        public ActionResult CadastrarSerie(
            [FromBody] SerieViewModel serieRecebido)
        {
            if (serieRecebido == null)
            {
                return BadRequest("Não foi recebido nenhumaa série.");
            }

            string nomeSerie = serieRecebido.Titulo;
            if (string.IsNullOrEmpty(nomeSerie))
            {
                return BadRequest("Nome da série não informado.");
            }

            //int temporadaSerie = temporadaRecebido.Temporadas;
            Serie serieCriado = _gestaoServices.CadastrarSerie(serieRecebido);
            return Created("serie", serieRecebido);
        }
    }
}
