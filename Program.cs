using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GestaoClientes clientes = new GestaoClientes();
            //clientes.Cadastrar();
            //clientes.Listar();

            GestaoProdutos produtos = new GestaoProdutos();
            produtos.Cadastrar();
            produtos.Listar();
        }
    }
}
