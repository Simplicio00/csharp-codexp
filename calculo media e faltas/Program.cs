using System;

namespace calculo_media_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App cálculo de média com situação");
            Console.WriteLine("Bem vindo");

            //entrada processamento e saída

            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            //processamento

            float media = (nota1+nota2)/2;

            if(media >=5 && faltas <=30){
                Console.WriteLine("Parabens, você conseguiu!!");
            }else{
                Console.WriteLine("Você não conseguiu");
            }
        }
    }
}
