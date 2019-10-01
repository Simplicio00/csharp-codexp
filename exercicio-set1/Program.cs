using System;

namespace exercicio_set1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] idade = new int[2];
            int contador = 0;
            int maiorIdade = 0;
            int menorIdade = 0;

        while (contador <2)
                {
                Console.WriteLine($"Digite a {contador+1} idade");
                idade[contador] = int.Parse(Console.ReadLine());

                if (idade[contador] >=18)
                {
                    maiorIdade++;
                }else{
                    menorIdade++;
                }

            Console.WriteLine($"Total de maiores = {maiorIdade} e menores = {menorIdade}");
            contador++;
            }
        }
    }
}
