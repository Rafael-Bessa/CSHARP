using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Produto
    {

        private string nome;
        private string codigo;
        private int quantidade;

        public Produto(string nome, string codigo, int quantidade)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.quantidade = quantidade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public override string ToString()
        {
            return $"O produto: {nome}, com preço de {codigo}, possui {quantidade} unidades em estoque";
        }
    }


}
