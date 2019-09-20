using System;

namespace lista_de_co
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string[6];
            int contador;

            contador = 0;

            while(contador<6){
                Console.WriteLine("Digite o nome do produto em que você deseja cadastrar");
                produto[contador] = Console.ReadLine();
                contador++;
            }//fim while


            contador = 0;

            while(contador<6){
                Console.WriteLine($" Os produtos cadastrados foram {produto[contador]}");
                contador++;
            } // fim while


        }
    }
}
