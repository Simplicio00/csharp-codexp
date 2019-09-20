using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double salarioreajuste;
            double salariototal;


            Console.WriteLine("Empresa decide dar aumento de 30% á funcionários que recebem 990 reais. Imprima o salário do funcionário e o valor reajustado; e uma mensagem caso o funcionário não tenha direito ao aumento.");

            
            Console.WriteLine("Digite o salário");

            salario = double.Parse(Console.ReadLine());

            if(salario < 990){

                Console.WriteLine("O salário teve direito á um aumento de 30%");
                salarioreajuste = salario *0.3;
                salariototal = salarioreajuste + salario;

                Console.WriteLine($"O salário re-ajustado é de: {salariototal}");

            }
            else{
                Console.WriteLine("O salário não teve direito a aumento.");
            };




            
        }
    }
}
