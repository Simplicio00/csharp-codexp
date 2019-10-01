using System;
using System.Collections.Generic;
using atrib.Model;

namespace atrib
{
    class Program
    {
        static void Main(string[] args)
        {

            List<FuncionarioModel> ListaDeFuncionarios = new List<FuncionarioModel>();

                int opcao;
                int acao = 0;
            do
            {
                
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Executar ações");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());
            

             FuncionarioModel funcionario = new FuncionarioModel();

            switch (opcao)
            {
                case 1:
                //cadastrar
             FuncionarioModel funcionarioCadastrado  =  funcionario.CadastroFuncionario();
             ListaDeFuncionarios.Add(funcionarioCadastrado);

             //listando o conteúdo

             foreach (var item in ListaDeFuncionarios)
             {
                 Console.WriteLine($"O funcionário {item.Nome}");
             }
                break;

                case 2:
                //executa

                do
                {
                    Console.WriteLine($"Selecione uma ação para {funcionario.Nome}, Cargo {funcionario.Cargo}");
                    Console.WriteLine("1 - Andar ");
                    Console.WriteLine("2 - Comer ");
                    Console.WriteLine("3 - Trabalhar");
                    Console.WriteLine("0 - Tchau");
                    acao = int.Parse(Console.ReadLine());

                    switch (acao)
                    {
                        case 1: 
                        funcionario.Andar();
                        break;
                        case 2: 
                        funcionario.Comer();
                        break;
                        case 3:
                        funcionario.Trabalhar();
                        break;
                        
                        case 0:
                        Console.WriteLine("Tchau");
                        break;

                        default:
                        Console.WriteLine("Inválido");
                        break;
                    }

                } while (acao != 0);

                break;
                case 3:
                //sair
                break;

                default:
                //diferente do 1, 2 e 0.
                break;
            }


            } while (opcao != 0);


        }
    }
}
