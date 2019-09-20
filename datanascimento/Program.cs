using System;

namespace datanascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int nascimentoAno;
            int anoAtual;
            int semana;
            int mes;
            //idade da pessoa

            Console.WriteLine("Digite o ano em que a pessoa nasceu:");
            nascimentoAno = int.Parse(Console.ReadLine());
            anoAtual = 2019-nascimentoAno;
            Console.WriteLine($"A idade da pessoa é: {anoAtual} anos");

            

            mes = 30;
            
            Console.WriteLine($"a idade da pessoa em meses é de: {mes}");
            
            semana = 6 *mes;

            Console.WriteLine($"A idade da pessoa em semanas é: {semana}");
            

            




















            








            
        }
    }
}
