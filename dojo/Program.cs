using System;

namespace dojo
{
    class Program
    {
        static void Main(string[] args)
        {

            int cadastrar = 0;
            int escolha;
            double total = 0;
            char resposta = 'N';
            string[] produto = new string[10]; 
            double[] preco = new double[10];

            do
            {
                Console.WriteLine("-------------Menu--------------");
                Console.WriteLine("1 - Cadastrar um produto");
                Console.WriteLine("2 - Listar todos os produtos");
                Console.WriteLine("3 - Calcular o preço em estoque");
                Console.WriteLine("0 - Sair");

                escolha = int.Parse(Console.ReadLine());

                switch(escolha){
                    case 1:
                        do
                        {
                            if (cadastrar < 10)
                            {
                                
                                Console.WriteLine($"Digite o nome do {cadastrar+1}º produto:");
                                produto[cadastrar] = Console.ReadLine();
                                    
                                Console.WriteLine($"Digite o preço do {cadastrar+1}º produto:");
                                preco[cadastrar] = double.Parse(Console.ReadLine());

                                Console.WriteLine("Deseja  cadastrar mais um produto?:");
                                Console.WriteLine("S/N ?");
                                resposta = char.ToUpper(char.Parse(Console.ReadLine()));

                                cadastrar++;
                            }
                            else
                            {
                                Console.WriteLine("O limite de cadastro de produtos foi excedido.");
                                break;
                            }
                        } while (resposta == 'S');
                        break;
                    case 2:
                        cadastrar = 0;
                        while (cadastrar < 2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Nome do {cadastrar+1}º Produto: {produto[cadastrar]}\n");
                            Console.WriteLine($"Preço do {cadastrar+1}º Produto: {preco[cadastrar]}\n");
                            Console.WriteLine("");
                            cadastrar++;
                        }
                        break;
                    case 3:
                        cadastrar = 0;
                        while(cadastrar < 2){
                            total += preco[cadastrar];
                            cadastrar++;
                        }
                        Console.WriteLine($"O preço total do estoque foi de: {total}");
                        break;
                    case 0:
                        break;
                }
            } while (escolha != 0);
        }
    }
}
