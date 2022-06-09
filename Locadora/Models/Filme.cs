using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Filme : Item
    {
        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
        public Guid IdFilme { get; set; } // GUID serve para criar ID

        public Filme (FilmeViewModel filmeRecebido)
        {
            Duracao = filmeRecebido.Duracao;
            QuantidadeDeOscars = filmeRecebido.qtdOscars;
        }
    }
}
