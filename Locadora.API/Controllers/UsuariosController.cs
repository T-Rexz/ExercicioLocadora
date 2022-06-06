using Locadora.API.Services;
using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {

        private UsuarioServices _usuarioServices = new UsuarioServices();

        [HttpPost]
        public ActionResult CadastrarUsuario(
            [FromBody] UsuarioViewModel usuarioRecebido)
        {
            if (usuarioRecebido == null)
            {
                return BadRequest("Não foi recebido nenhum usuário.");
            }
            
            string nomeDoUsuario = usuarioRecebido.Nome;
            if (string.IsNullOrEmpty(nomeDoUsuario))
            {
                return BadRequest("Nome de usuário não informado");
            }
            
            if (usuarioRecebido.Idade < 18)
            {
                return BadRequest("Não é permitido o cadastro de usuário.");
            }
            // Garantir que o serviço vai receber o objeto
            // apropriado, como assim? Já explico!
            Usuario objetoCriado = _usuarioServices.CadastrarUsuario(usuarioRecebido);
            return Created("usuarios", usuarioRecebido);
        }

        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
            // Armazenamento vai precisar colocar o
            // using AulasPCDev.Respository;
            // no inicio do código
            // Ctrl + . é um atalho para adicionar esse using.

            List<Usuario> listaUsuario =
                Armazenamento.Usuarios;
            return listaUsuario;
        }
    }
}
