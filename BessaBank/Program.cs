
using BessaBank;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Conta conta1 = new Conta (0.0, "Rafael");
        Conta conta2 = new Conta(200.0, "Bessa");
        Console.WriteLine(conta1.ToString()); //0

        conta1.Deposita(100.0);
        conta1.Saca(50.0);
        Console.WriteLine(conta1.ToString()); //50
        conta2.Transfere(50.0, conta1);
        Console.WriteLine("***********************************************************************");
        Console.WriteLine(conta1.ToString()); //100
        Console.WriteLine(conta2.ToString()); // 150

    }
}