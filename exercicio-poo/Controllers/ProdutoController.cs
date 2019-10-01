using System;
using System.Collections.Generic;
using exercicio_poo.Models;

namespace exercicio_poo.Controllers
{
    public class ProdutoController
    {

        List<ProdutoModel> ListaDeProdutos = new List<ProdutoModel>();
        
        public void CadastroDeProduto(){

             Console.WriteLine("Digite o Nome do produto: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informe sua Categoria: ");
            string Categoria = Console.ReadLine();
             Console.WriteLine("Informe a quantidade em estoque: ");
            int EstoqueQtd = int.Parse(Console.ReadLine());
             Console.WriteLine("Informe o preco da unidade ");
            int Preco = int.Parse(Console.ReadLine());
            int TotalDaSoma = EstoqueQtd*Preco;

            ProdutoModel produto = new ProdutoModel();
            produto.Id = ListaDeProdutos.Count + 1;
            produto.Nome = Nome;
            produto.Categoria = Categoria;
            produto.EstoqueQtd = EstoqueQtd;
            produto.Preco = Preco;
            produto.DataDeCadastro = DateTime.Now;
            produto.TotalDaSoma = TotalDaSoma;
            produto.Total = TotalDaSoma++;               

            ListaDeProdutos.Add(produto);
        }// fim cadastro de produtos

        public void ListarProdutos(){
            foreach (var item in ListaDeProdutos){
            System.Console.WriteLine($@"
            ____________________________
            O produto: {item.Nome}
            O ID: {item.Id}
            O Categoria: {item.Categoria}
            Estocado: {item.EstoqueQtd}
            Valor da unidade: R${item.Preco}
            O valor em estoque foi de: R$ {item.TotalDaSoma}
            O valor total em produto foi de: R$ {item.Total}
            _______________________________

            ");

            }// fim foreach


        }// fim ListarProdutos

























    }
}