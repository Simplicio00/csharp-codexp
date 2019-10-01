using System;
using exercicio_poo.Controllers;

namespace exercicio_poo
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            ProdutoController produtos = new ProdutoController();


            do
            {
                System.Console.WriteLine("1 - Cadasrar produto");
                System.Console.WriteLine("2 - Listar produtos");
                System.Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    produtos.CadastroDeProduto();
                    
                    break;
                    case 2:
                    produtos.ListarProdutos();
                    break;

                    case 0: 
                    System.Console.WriteLine("Volte sempre! ;)");
                    break;
                    default:
                    System.Console.WriteLine("Opção inválida");
                    break;
                }// fim do switch

            } while (opcao != 0);//fim while


            
        }
    }
}
