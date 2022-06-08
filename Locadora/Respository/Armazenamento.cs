using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Respository
{
    public class Armazenamento
    {
        public static List<Usuario> Usuarios =
            new List<Usuario>();

        public static List<Item> Biblioteca =
            new List<Item>();

        // Dúvida - é necessário o comando List Item tb?
        public static List<Item> Itens =
            new List<Item>();

        public static List<Filme> Filmes =
            new List<Filme>();

        public static List<Serie> Series =
            new List<Serie>();
    }
}
