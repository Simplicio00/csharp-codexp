using System;

namespace nome_salario_codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string codigo;
            int salario;
            double porcentagem;
        

            Console.WriteLine("Insira o nome do funcionário");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o salário");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("1 - Escrituário");
            Console.WriteLine("2 - Secretário");
            Console.WriteLine("3 - Caixa");
            Console.WriteLine("4 - Gerente");
            Console.WriteLine("5 - Diretor");
            Console.WriteLine("________________");
            Console.WriteLine("Insira um número correspondente de 1 a 5");
            codigo = Console.ReadLine();



            switch(codigo){
                case "1":
                porcentagem = salario*0.5;
                Console.WriteLine($"O nome do funcionário: {nome}");
                Console.WriteLine($"O salário é de {salario}");
                Console.WriteLine($"O percentual será de 50% {porcentagem}");
                Console.WriteLine("O cargo é de Escrituário");
                break;

                 case "2":
                porcentagem = salario*0.35;
                Console.WriteLine($"O nome do funcionário: {nome}");
                Console.WriteLine($"O salário é de {salario}");
                Console.WriteLine($"O percentual será de 35% {porcentagem}");
                Console.WriteLine("O cargo é de Secretário");
                break;

                 case "3":
                 porcentagem = salario*0.2;
                Console.WriteLine($"O nome do funcionário: {nome}");
                Console.WriteLine($"O salário é de {salario}");
                Console.WriteLine($"O percentual será de 20% {porcentagem}");
                Console.WriteLine("O cargo é de Caixa");
                break;

                 case "4":
                porcentagem = salario*0.1;
                Console.WriteLine($"O nome do funcionário: {nome}");
                Console.WriteLine($"O salário é de {salario}");
                Console.WriteLine($"O percentual será de 10% {porcentagem}");
                Console.WriteLine("O cargo é de Gerente");
                break;

                 case "5":
                Console.WriteLine($"O nome do funcionário: {nome}");
                Console.WriteLine($"O salário é de {salario}");
                Console.WriteLine("Não tem aumento");
                Console.WriteLine("O cargo é de Diretor");
                break;
            }
        }
    }
}
