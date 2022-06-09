using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Serie : Item
    {
        //public Guid IdSerie { set; get; }
        public int Temporadas { get; set; }
        public int Emmies { get; set; }

        private SerieViewModel serieRecebido;
        public Guid IdSerie { get; set; }

        public Serie (SerieViewModel serieRecebido)
        {
            Temporadas = serieRecebido.Temporadas;
            Emmies = serieRecebido.Emmies;
        }
    }
}
