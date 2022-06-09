using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        //alterei private pra public
        public List<Item> _biblioteca = Armazenamento.Biblioteca;
        // tirei void

        public List<object> ListarItens()
        {
            List<object> lista = new List<object>();

            //lista.AddRange(_series);
            //lista.AddRange(_filmes);
            return lista;
        }

        public void Filme(FilmeViewModel filmeBase)
        {
            string filmeTitulo = filmeBase.Titulo;
        }

        
        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(); //Este filme é vazio

            filme.Titulo = filmeRecebido.Titulo;
            filme.Descricao = filmeRecebido.Descricao;
            filme.Duracao = filmeRecebido.Duracao;
            filme.QuantidadeDeOscars = filmeRecebido.qtdOscars;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;

            _biblioteca.Add(filme);
            return filme;

            //Console.WriteLine("Qual o nome do filme que deseja cadastrar?");
            //filme.Titulo = Console.ReadLine();

            //Console.WriteLine("Quantos fitas deste filme existem?");
            //filme.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o valor da locação deste filme?");
            //filme.Valor = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual a duração do filme?");
            //filme.Duracao = int.Parse(Console.ReadLine());
        }
        public List<Filme> ListarFilmes()
        {
            return Armazenamento.Filmes;
        }
        public Serie CadastrarSerie(SerieViewModel serieRecebido)
        {
            Serie serie = new Serie();
            serie.Titulo = serieRecebido.Titulo;
            serie.Temporadas = serieRecebido.Temporadas;

            _biblioteca.Add(serie);
            return serie;
            
            //Console.WriteLine("Qual o nome da série que deseja cadastrar?");
            //serie.Titulo = Console.ReadLine();

            //Console.WriteLine("Quantos cópias desta série existem?");
            //serie.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o valor da locação deste séries?");
            //serie.Valor = int.Parse(Console.ReadLine());

            //Console.WriteLine("Quantas temporadas tem esta série?");
            //serie.Temporadas = int.Parse(Console.ReadLine());
        }
        public List<Serie> ListarSeries()
        {
            return Armazenamento.Series;
        }
    }
}
