using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Serie : Item
    {
        public Serie(SerieViewModel serieBase)
        {
            string serieTitulo = serieBase.Titulo;
        }
        public int Temporadas { get; set; }
        public int Emmies { get; set; }
    }
}
