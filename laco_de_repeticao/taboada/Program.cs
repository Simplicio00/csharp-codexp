using System;

namespace taboada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int limite;
            int multiplica;
            int multiresp;

            Console.WriteLine("Bem vindo á taboada!!");
            Console.WriteLine("Digite o número da taboada que você deseja saber de 1 á 10:");
            
            limite = 9;
            numero = 0; 
            multiplica = int.Parse(Console.ReadLine());

              Console.WriteLine($"__TABOADA__DO__NÚMERO__{multiplica}__");

            while(numero <= limite){

                Console.WriteLine("_______________________________");
              
                numero = numero +1;
                multiresp = multiplica*numero;   
                Console.WriteLine(multiresp);
            
            }   //fim-while
        }
    }
}