using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            float mercadoria;
            float valoracrescimo;
            float valortotal;
            // int valorbruto;

            Console.WriteLine("Digite o preço total da mercadoria");

            mercadoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o acréscimo em porcentagem");

            valoracrescimo =  float.Parse(Console.ReadLine());

            valoracrescimo = valoracrescimo *0.10;

            valortotal = valoracrescimo+valoracrescimo;

            Console.WriteLine($"O valor total é de: {valortotal}");










        }
    }
}
