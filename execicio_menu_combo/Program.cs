using System;

namespace execicio_menu_combo
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitado1;
            int digitado2;
            int resultado;
            string opcao;

            Console.WriteLine("Digite o primeiro número");
            Console.WriteLine("____________________");
            digitado1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número");
            Console.WriteLine("____________________");
            digitado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma  das opções");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração do primeiro pelo segundo");
            Console.WriteLine("3 - Subtração do segundo pelo primeiro");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Divisão do primeiro pelo segundo");
            Console.WriteLine("6 - Divisão do segundo pelo primeiro");
            opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                resultado = digitado1+digitado2;
                Console.WriteLine($"Resultado{resultado}");
                break;

                case "2":
                resultado = digitado1-digitado2;
                Console.WriteLine($"Resultado{resultado}");
                break;

                 case "3":
                resultado = digitado2-digitado1;
                Console.WriteLine($"Resultado{resultado}");
                break;

                 case "4":
                resultado = digitado1*digitado2;
                Console.WriteLine($"Resultado{resultado}");
                break;

                 case "5":
                resultado = digitado1/digitado2;
                Console.WriteLine($"Resultado{resultado}");
                break;

                 case "6":
                resultado = digitado2/digitado1;
                Console.WriteLine($"Resultado{resultado}");
                break;
            }
        }
    }
}
