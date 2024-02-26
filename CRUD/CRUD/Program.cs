
using CRUD;

class Program
{
    private static void Main(string[] args)
    {

        List<Produto> loja = new List<Produto>();


        Produto p1 = new Produto("Refrigerante 2L", "1172", 120);
        Produto p2 = new Produto("Leite Integral 1L", "1432", 240);
        Produto p3 = new Produto("Arroz 5kg", "1922", 20);
        Produto p4 = new Produto("Feijão 1kg", "3323", 25);

        Operador operador = Operador.ObterInstancia();
        operador.adicionaProduto(p1, loja);
        operador.adicionaProduto(p2 , loja);
        operador.adicionaProduto(p4 , loja);
        operador.adicionaProduto(p3, loja);
        Console.WriteLine("*******************************************");
        operador.buscaProduto("1922", loja);
        operador.excluiProduto(p4, loja);
        operador.atualizaProduto(p1, "1172", "Refrigerante 2L", 220);

    }
}