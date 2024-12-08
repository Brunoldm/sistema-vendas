using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_vendas
{
    internal interface IGestao
    {
        void Cadastrar();
        T Buscar<T>(string codigo) where T : class;
        void Listar();
    }
}
