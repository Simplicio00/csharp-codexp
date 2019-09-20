using System;

namespace execicio_menu_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string digitado1;
            string digitado2;


             Console.WriteLine("Digite um número de 1 a 9");
            Console.WriteLine("____________________");
            digitado1 = Console.ReadLine();

            
             Console.WriteLine("Digite um número de 1 a 9");
            Console.WriteLine("____________________");
            digitado2 = Console.ReadLine();
            

            // if (digitado1 % 2 == 0)
            // {
            //     Console.WriteLine("par");
                
            // }else{
            //     Console.WriteLine("Impar");
            // }


            switch(digitado1){
                case "1":
                Console.WriteLine("O número é ímpar");
                break;

                case "3":
                Console.WriteLine("O número é ímpar");
                break; 

                case "5":
                Console.WriteLine("O número é ímpar");
                break;

                case "7":
                Console.WriteLine("O número é ímpar");
                break;

                case "9":
                Console.WriteLine("O número é ímpar");
                break;
                

                case "2":
                Console.WriteLine("O número é par");
                break;

                case "4":
                Console.WriteLine("O número é par");
                break;

                case "6":
                Console.WriteLine("O número é par");
                break;

                case "8":
                Console.WriteLine("O número é par");
                break;
            }

            
            switch(digitado2){

                case "1":
                Console.WriteLine("O número é ímpar");
                break;
                
                case "3":
                Console.WriteLine("O número é ímpar");
                break; 

                case "5":
                Console.WriteLine("O número é ímpar");
                break;

                case "7":
                Console.WriteLine("O número é ímpar");
                break;

                case "9":
                Console.WriteLine("O número é ímpar");
                break;
                

                case "2":
                Console.WriteLine("O número é par");
                break;

                case "4":
                Console.WriteLine("O número é par");
                break;

                case "6":
                Console.WriteLine("O número é par");
                break;

                case "8":
                Console.WriteLine("O número é par");
                break;
                
            }


            int resultado1;
            int resultado2;

            resultado1 = int.Parse(digitado1);
            resultado2 = int.Parse(digitado2);

            
                  if( resultado1 > resultado2){
            Console.WriteLine($"O {resultado1} é maior que o {resultado2}");   
            }
            else if(resultado1 < resultado2){
            Console.WriteLine($"O {resultado2} é maior que o {resultado1}");                
            }
            else{
                Console.WriteLine("Os números são equivalentes");
            }
        }
    }
}