using System;

namespace exercicio_poo.Models
{
    public class ProdutoModel 
    {
          
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public int EstoqueQtd { get; set; }
        public int Preco { get; set; }

        public int TotalDaSoma { get; set; }

        public int Total { get; set; }


    }
}