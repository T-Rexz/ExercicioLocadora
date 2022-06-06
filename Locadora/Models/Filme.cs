using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Filme : Item
    {
        public Filme (FilmeViewModel filmeBase)
        {
            string filmeTitulo = filmeBase.Titulo;
        }
        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
    }
}
