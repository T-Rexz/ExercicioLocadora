using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Usuario
    {
        private readonly static int IDADE_MAIORIDADE = 18;

        public Guid Id { get; set; } // GUID é para criar ID

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Conta Conta { get; set; }

        public Usuario(UsuarioViewModel usuarioBase)
        {
            Nome = usuarioBase.Nome;            
            if (usuarioBase.Idade >= IDADE_MAIORIDADE)
            {
                Idade = usuarioBase.Idade;
                Conta = new Conta(50);
            }
            else
            {
                throw new Exception();
            }
            Nome = usuarioBase.Nome;
            Id = Guid.NewGuid();
        }
    }
}
