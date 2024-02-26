using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Operador
    {
        private Operador() { }

        private static Operador instancia = null;

        public static Operador ObterInstancia()
        {
            if (instancia == null)
            {
                instancia = new Operador();
            }
            return instancia;
        }

        public void adicionaProduto(Produto produto, List<Produto> lista)
        {
            lista.Add(produto);
            Console.WriteLine($"Acabei de adicionar o produto: {produto.Nome}");
        }

        public void excluiProduto(Produto produto, List<Produto> lista)
        {
            lista.Remove(produto);
            Console.WriteLine($"Acabei de excluir o produto: {produto.Nome}");
        }

        public void buscaProduto(string codigo, List<Produto> lista)
        {

            bool tem = false;

            foreach (Produto produto in lista)
            {
                if (codigo.Equals(produto.Codigo))
                {
                    Console.WriteLine("O produto está na loja");
                    tem = true;
                    break;
                }
            } 

            if(!tem) 
            {
                Console.WriteLine("O produto não está na loja");
            }
        }

        public void atualizaProduto(Produto produto, string codigo, string nome, int quantidade)
        {
            produto.Codigo = codigo;
            produto.Nome = nome;
            produto.Quantidade = quantidade;

            Console.WriteLine($"Produto atualizado");
        }

    }
}
