using System;

namespace validacao
{
    class Program
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("Validação");


        string nome;
        string senha;

        do
        {   
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
        }  while(nome.Length <=1);

        do
        {
            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();
        }   while (senha.Length <=6);
        
        }
    }
}