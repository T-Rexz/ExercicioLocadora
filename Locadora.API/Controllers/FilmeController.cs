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

        [HttpPost] // POST da api/filme
        public ActionResult CadastrarFilme(
            [FromBody] FilmeViewModel filmeRecebido)
        {
            if (filmeRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum filme.");
            }

            int oscarFilme = filmeRecebido.qtdOscars;
            string nomeFilme = filmeRecebido.Titulo;
            if (string.IsNullOrEmpty(nomeFilme))
            {
                return BadRequest("Nome do filme não informado.");
            }

            Filme filmeCriado = _gestaoServices.CadastrarFilme(filmeRecebido);
            return Created("filme", filmeRecebido);
        }

        public List<Filme> ListarFilmes()
        {
            // Armazenamento vai precisar colocar o
            // using AulasPCDev.Respository;
            // no inicio do código
            // Ctrl + . é um atalho para adicionar esse using.

            List<Filme> listaFilmes =
                Armazenamento.Filmes;
            return listaFilmes;
        }
    }
}
