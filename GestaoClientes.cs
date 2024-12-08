using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace sistema_vendas
{
    internal class GestaoClientes : IGestao
    {
        private List<Cliente> clientes = new List<Cliente>();
        public T Buscar<T>(string codigo) where T : class
        {
            throw new NotImplementedException();
        }

        public void Cadastrar()
        {
            Console.Write("Insira o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Insira a idade do cliente: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Insira o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Cliente novoCliente = new Cliente(nome, idade, cpf);
            clientes.Add(novoCliente);
            Console.WriteLine("Cadastrado efetuado com sucesso.\n");
        }

        public void Listar()
        {
            Console.WriteLine("Código - Nome");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{cliente.Codigo} - {cliente.Nome}");
            }
        }
    }
}
