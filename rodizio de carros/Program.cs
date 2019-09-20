using System;

namespace rodizio_de_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;

            Console.WriteLine("Escreva uma placa");
            placa = Console.ReadLine();

            int caracteres = placa.Length;
            int final = int.Parse(placa.Substring(caracteres - 1));
            Console.WriteLine($"A posição é: {final}");

            if(final == 1 || final == 0){
                Console.WriteLine("Seu rodizio é na segunda-feira");
            }else if(final == 2 || final == 3){
                Console.WriteLine("Seu rodizio é na terça-feira");
            }
            else if(final == 4 || final == 5){
                Console.WriteLine("Seu rodizio é na quarta-feira");
            }
            else if(final == 6 || final == 7){
                Console.WriteLine("Seu rodizio é na quinta-feira");
            }
            else if(final == 8 || final == 9){
                Console.WriteLine("Seu rodizio é na sexta-feira");
            }else{
                Console.WriteLine("É aceito apenas um dígito");
            }
        }
    }
}