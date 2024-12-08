using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas
{
    internal class Cliente : IEntidade
    {
        private static int counter = 0;

        public int Codigo { get; protected set; }
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }
        public string Cpf { get; set; }

        public Cliente(string nome, int idade, string cpf) {
            this.Codigo = counter;
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            counter++;
        }
    }
}
