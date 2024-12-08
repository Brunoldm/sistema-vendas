using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas
{
    internal class Produto : IEntidade
    {
        private static int counter = 0;
        public int Codigo { get; protected set; }
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string Descricao { get; protected set; }
        public double Preco {  get; protected set; }

        public Produto(string marca, string modelo, string descricao, double preco)
        {
            this.Codigo = counter;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Descricao = descricao;
            this.Preco = preco;
            counter++;
        }
    }
}
