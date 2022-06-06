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
    [Route("filme")]
    public class FilmeController : BibliotecaController
    {
        private GestaoServices _gestaoServices = new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarFilme([FromBody] FilmeViewModel filmeRecebido)
        {
            if (filmeRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum filme.");
            }

            string nomeFilme = filmeRecebido.Titulo;
            if (string.IsNullOrEmpty(nomeFilme))
            {
                return BadRequest("Nome do filme não informado.");
            }

            //int oscarFilme = oscarRecebido.QuantidadeDeOscars;
            //Filme filmeCriado = _gestaoServices.CadastrarFilmes(filmeRecebido);
            return Created("filme", filmeRecebido);
        }

        //private GestaoServices _filmeServices = new GestaoServices();
        //[HttpPost]
        //public ActionResult CadastrarFilmes(
        //    [FromBody] FilmeViewModel filmeRecebido)
        //{
        //    string nomeDoFilme = filmeRecebido.Titulo;
        //}

    }
}
