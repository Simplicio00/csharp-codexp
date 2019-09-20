using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int idade;
            int diasTotal;
            int meses;
            int horasTotal;
            int horas;
            int minutos;


            // cálculo em dias

            Console.WriteLine("Digite a idade de uma pessoa: ");

            idade = int.Parse(Console.ReadLine());

            diasTotal = idade*365;

            Console.WriteLine($"A idade em dias é de: {diasTotal} dias");

            // cálculo em meses

            meses = diasTotal /30;

            Console.WriteLine($"A idade em meses é de: {meses} meses");

            //  cálculo em horas

            horas = 24;

            horasTotal = horas*365;

            Console.WriteLine($"A idade em horas é de: {horasTotal} horas");

            // cálculo em minutos

            minutos = horas*60;

            Console.WriteLine($"A idade em minutos é de: {minutos} minutos");
        }
    }
}
