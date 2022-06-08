﻿using Locadora.API.Services;
using Locadora.Models;
using Locadora.Respository;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("biblioteca")]
    public class BibliotecaController : ControllerBase
    {
        //private GestaoServices _gestaoServices = new GestaoServices();

        [HttpGet]
        public List<Item> Listar()
        {
            List<Item> listaItens =
                Armazenamento.Biblioteca;
            return listaItens;
        }
        //public List<Item> ListarSeries()
        //{
        //    List<Item> listaSerie =
        //        Armazenamento.Biblioteca;
        //    return listaSerie;
        //}

        /*
         * https://localhost:5001/locadora
         * HTTPS => Protocolo
         * localhost => aonde está o site
         * 5001 => porta que o servidor está usando
         * locadora => rota
         * 
         * https://localhost:5001/api/locadora
         */
    }
}
