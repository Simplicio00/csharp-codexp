using System;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            
            Console.WriteLine("Digite a idade do nadador para mostrar a categoria");

            idade = int.Parse(Console.ReadLine());

            if(idade <= 7){

                    Console.WriteLine("Categoria infantil A");
                
            }else if(idade <= 10){
                    Console.WriteLine("Categoria infantil B");
            }else if(idade <= 13){
                    Console.WriteLine("Categoria Juvenil A");
            }else if(idade <=17){
                Console.WriteLine("Categoria Juvenil B");
            } else{
                Console.WriteLine("Categoria adulto");
            }
        }
    }
}
