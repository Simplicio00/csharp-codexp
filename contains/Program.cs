using System;

namespace contains
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            string email;
            string senha;
            
            do{
            Console.WriteLine("Informe seu email");
            email = Console.ReadLine();
            }while(!email.Contains("@") && !email.Contains("."));

            do{
                Console.WriteLine("Informe uma senha");
                senha = Console.ReadLine();
            }while(senha.Length <= 8);


                 //&& - Um ou outro, condicional;
                // || - Junto;
                // ! -  negação;

        }
    }
}