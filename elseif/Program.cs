using System;

namespace elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________media escolar!_________");

            Console.WriteLine("Digite o seu nome");

            string nome = Console.ReadLine();

            
            Console.WriteLine("Digite as tres notas");

            float nota1 = float.Parse(Console.ReadLine());

            float nota2 = float.Parse(Console.ReadLine());

            float nota3 = float.Parse(Console.ReadLine());

            float media = (nota1+nota2+nota3)/3;

            string resultado = "Aprovado";

            if(media <=7){
                resultado = "Reprovado";
            }

            Console.WriteLine($"O aluno {nome} com a media {media} está {resultado}");
        }
    }
}