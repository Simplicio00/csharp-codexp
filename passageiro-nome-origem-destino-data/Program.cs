using System;

namespace passageiro_nome_origem_destino_data
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime[] data = new DateTime[4];
            string[] nome = new string[4];
            string[] destino = new string[4];
            string[] origem = new string[4];
            string resposta; // Condicional para resposta
            int opcao = 0; // inserção de escolha para 0, 1 e 2..
            int contador = 0;   // contador para controle de repetição  
            int contadorB = 0; // contador para controle de registro e repetição

            do{
                
                Console.WriteLine("Agência de turismo");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - cadastrar passageiro");
                Console.WriteLine("2 - listar passageiro");
                Console.WriteLine("0 - sair");
                opcao = int.Parse(Console.ReadLine());
                
                switch(opcao){ //casos para quando se é escolhida a opcao entre os números 0 e 2;
                
                case 1:

                //se digitado 1

                do{ if(contador<2){
                        
                    Console.WriteLine("vamos cadastrar agora");
                    Console.WriteLine("Digite o nome do passageiro");
                    nome[contador] = Console.ReadLine();

                    Console.WriteLine("Digite a origem");
                    origem[contador] = Console.ReadLine();

                    Console.WriteLine("Digite o destino");
                    destino[contador] = Console.ReadLine();

                    Console.WriteLine("Digite a data do vôo");
                    data[contador] = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Você deseja cadastrar mais um? S/N");
                    resposta = Console.ReadLine();
                    contador++; 
                    
                    } //fim if

                    else{
                    Console.WriteLine("Numero de passagens excedidas");
                    }

                    break;
                    }//fim do


                    while(resposta == "S");
                    break;
                    // Se a resposta for diferente de "S", então pare.


                        
                    case 2:
                    Console.WriteLine("Listando as passagens");

                    while(contadorB<2){
                        Console.WriteLine($"{nome[contadorB]}, {origem[contadorB]} {destino[contadorB]}");
                        contadorB++;
                    }
                        break;
                    
                    
                    
                    
                    case 0:
                    Console.WriteLine("Obrigado por usar nosso sistema");
                    break;

                    default:
                     Console.WriteLine("Opção inválida");
                     break;
                    }
                        }while(opcao !=0);
                        // 
        }
    }
}