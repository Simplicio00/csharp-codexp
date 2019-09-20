using System;

namespace primeiro_ap
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Soma de dois números");
        //campo para a declaração das variáveis...

        int n1;
        int n2;
        int n3;
        float resultado;
        float media;

        //campo para a sequência de comandos...

        Console.WriteLine("Digite o primeiro número");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número");
        n3 = int.Parse(Console.ReadLine());
        
        resultado = n1+n2+n3;

        Console.WriteLine($"O resultado é: {resultado}");

        media = resultado /3;

        Console.WriteLine($"A média é: {media}");
        
        }
    }
}