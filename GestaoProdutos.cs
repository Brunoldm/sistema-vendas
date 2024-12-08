using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace sistema_vendas
{
    internal class GestaoProdutos : IGestao
    {
        private List<Produto> produtos = new List<Produto>();
        public T Buscar<T>(string codigo) where T : class
        {
            throw new NotImplementedException();
        }

        public void Cadastrar()
        {
            Console.Write("Insira a marca do produto: ");
            string marca = Console.ReadLine();
            Console.Write("Insira o modelo do produto: ");
            string modelo = Console.ReadLine();
            Console.Write("Insira a descrição do produto: ");
            string descricao = Console.ReadLine();
            Console.Write("Insira o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Produto novoProduto = new Produto(marca, modelo, descricao, preco);
            produtos.Add(novoProduto);
            Console.WriteLine("Cadastrado efetuado com sucesso.\n");
        }

        public void Listar()
        {
            Console.WriteLine("Código - Marca - Modelo");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Codigo} - {produto.Marca} - {produto.Modelo}");
            }
        }
    }
}
