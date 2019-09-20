using System;

namespace exercicio_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade");

            int idade;
            // int idademaior;
            // int idademenor;

            
            idade = int.Parse(Console.ReadLine());

            if(idade >=60 || idade <18){

                Console.WriteLine("A idade selecionada tem direito á meia entrada.");

            }else{
                Console.WriteLine("A idade selecionada não tem direito á meia entrada.");
            }
        }
    }
}
