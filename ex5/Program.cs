using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor");
            int valorinserir = int.Parse(Console.ReadLine());

            int calculo = valorinserir *3;

            Console.WriteLine($"O valor triplicado é de: {calculo}");

        }
    }
}
