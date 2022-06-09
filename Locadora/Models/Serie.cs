using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Serie : Item
    {
        public int Temporadas { get; set; }
        public int Emmies { get; set; }
        public Guid IdSerie { get; set; }

        public Serie (SerieViewModel serieRecebido)
        {
            Temporadas = serieRecebido.Temporadas;
            Emmies = serieRecebido.Emmies;
        }
    }
}
