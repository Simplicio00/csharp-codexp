using System;

namespace primeiro_ap
{
    class Program
    {
        static void Main(string[] args)
        // Console.WriteLine("Olá mundo!");
        {
        // Aqui é onde inserimos o corpo

        Console.WriteLine("Soma de dois números");
        int n1;
        int n2;
        int resultado;

        Console.WriteLine("Digite o primeiro número");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        n2 = int.Parse(Console.ReadLine());

        
        resultado = n1+n2;

        Console.WriteLine($"O resultado e: {resultado}");

 







        }
    }
}