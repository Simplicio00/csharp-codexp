using System;

namespace produtos_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastramento de produtos");

            string[] produtoNome = new string [3];
            double[] produtoPreco = new double [3];
            int contador = 0;
           

            for (int i=0; i< 3; i++) {
            Console.WriteLine($"Digite o nome do {i+1}º do produto");
            produtoNome[i] = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            produtoPreco[i] = double.Parse(Console.ReadLine());

          }

          foreach (var produto in produtoNome)
          {     
              Console.WriteLine($"Produto {produto} e preço {produtoPreco[contador]}");
              contador++;
          }



        }
    }
}
