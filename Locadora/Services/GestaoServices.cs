﻿using Locadora.Models;
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
        public void Cadastrar(FilmeViewModel filmeRecebido, SerieViewModel serieRecebido)
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respostas = int.Parse(Console.ReadLine());
            if (respostas == 1)
            {
                CadastrarFilme(filmeRecebido);
            }
            if (respostas == 2)
            {
                CadastrarSerie(serieRecebido);
            }
        }

        public void CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(filmeRecebido);

            Console.WriteLine("Qual o nome do filme que deseja cadastrar?");
            filme.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos fitas deste filme existem?");
            filme.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste filme?");
            filme.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a duração do filme?");
            filme.Duracao = int.Parse(Console.ReadLine());

            Armazenamento.Biblioteca.Add(filme);
            _biblioteca.Add(filme);

        }

        public void CadastrarSerie(SerieViewModel serieRecebido)
        {
            Serie serie = new Serie(serieRecebido);

            Console.WriteLine("Qual o nome da série que deseja cadastrar?");
            serie.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos cópias desta série existem?");
            serie.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste séries?");
            serie.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas temporadas tem esta série?");
            serie.Temporadas = int.Parse(Console.ReadLine());

            Armazenamento.Biblioteca.Add(serie);
            _biblioteca.Add(serie);
        }
    }
}
