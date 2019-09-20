using System;

namespace laco_de_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int contador;
            int limite;        
            Console.WriteLine("Laço de repetição 'while'....");
            contador = 5;

            Console.WriteLine("Digite o valor limite");
            limite = int.Parse(Console.ReadLine());




            while(contador <= limite){
                Console.WriteLine(contador);
                contador = contador +1;
            }//fim do while



        }
    }
}
