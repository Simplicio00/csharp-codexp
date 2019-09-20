using System;

namespace Array_x2
{
    class Program
    {
        static void Main(string[] args)
        {
            //efetuar o cadastro do nome de usuário 5x;
            //dados nome, telefone e e-mail;
            string[] nome = new string[5];
            string[] telefone = new string[5];
            string[] email = new string[5];
            int contador = 0;

            Console.WriteLine("Bem vindo ao cadastramento de usuários por nome, telefone e e-mail");
        
            while(contador<2){
                Console.WriteLine("Digite seu nome");
                nome[contador] = Console.ReadLine();

                Console.WriteLine("Digite seu telefone");
                telefone[contador] = Console.ReadLine();   

                Console.WriteLine("Digite seu e-mail");
                email[contador] = Console.ReadLine();

                contador++;

            }//fim while

            contador = 0;

            while(contador <=2){
                
                
                Console.WriteLine($"O cliente  {nome[contador+1]} - e-mail {email[contador]}, Telefone {telefone[contador]}");
                contador++;

            }//fim while
        }
    }
}
