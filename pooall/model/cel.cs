using System;

namespace pooall.model{
    public class cel
    {
        
        public string Modelo { get; set; }

        public string Tipo { get; set; }

        public string Cor { get; set; }

        public int escolha {get; set; }




            public void CadastrarProduto(){
            do
            {
            Console.WriteLine("Digite o modelo do celular");
            Modelo = Console.ReadLine();

            Console.WriteLine("Digite as dimensões do celular");
            Tipo = Console.ReadLine();

            Console.WriteLine("Digite a cor celular");
            Cor = Console.ReadLine();
                     
                Console.Clear();
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - mostrar");
                Console.WriteLine("0 - sair");
                escolha = int.Parse(Console.ReadLine());

            switch (escolha){
                
            case 1:
            Console.Clear();            
            Console.WriteLine($@"
            Modelo :{Modelo} 
            Dimensões :{Tipo}
            Cor: {Cor}
            ");

            break;
            }

            } while (escolha != 0);

    }
}

}