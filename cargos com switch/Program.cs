using System;

namespace cargos_com_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do seu cargo para descobrir o salário: ");

            Console.WriteLine("(1) - Diretor");
            Console.WriteLine("(2) - Gerente");
            Console.WriteLine("(3) - Professor");
            Console.WriteLine("(4) - Coordenador");
            Console.WriteLine("(5) - Atendente");

            string resposta = Console.ReadLine();
            
            switch(resposta){
                case "1":
                Console.WriteLine("O salário de diretor é de R$18 mil");
                break;
                
                case "2":
                Console.WriteLine("O salário de gerente é de R$10 mil");
                break;

                case "3":
                Console.WriteLine("O salário de Professor é de R$5 mil");
                break;

                case "4":
                Console.WriteLine("O salário de diretor é de R$8 mil");
                break;

                case "5":
                Console.WriteLine("O salário de atendente é de R$6 mil");
                break;
    
                default:
                Console.WriteLine(" Dados inválidos");
                break;
            } 

        }
    }
}
