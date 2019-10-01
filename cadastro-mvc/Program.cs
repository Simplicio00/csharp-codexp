using System;
using cadastro_mvc.Controllers;

namespace cadastro_mvc
{

    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            
            UsuarioControllers usuariocontrollers = new UsuarioControllers();


            do
            {
                System.Console.WriteLine("1 - Cadastrar Usuário");
                System.Console.WriteLine("2 - Listar usuários");
                System.Console.WriteLine("3 - Autenticação");
                System.Console.WriteLine("0 - Sair ");
                opcao = int.Parse(Console.ReadLine()); 

                switch (opcao)
                {
                    case 1:
                    //cadastrar
                    usuariocontrollers.CadastroUsuario();
                    break;
                    
                    case 2:
                    //listar
                    usuariocontrollers.ListarUsuarios();

                    break;

                    case 3:
                    //Autenticando email e senha
                    bool usuarioRetornado = usuariocontrollers.Logar();
                    if (usuarioRetornado)
                    {
                        System.Console.WriteLine("Usuário localizado");
                        
                    }else{
                        System.Console.WriteLine("Usuário não encontrado");
                    }
                    break;

                    case 0:
                    //sair
                    System.Console.WriteLine("Até mais ver");
                    break;

                    default:
                    System.Console.WriteLine("Opção inválida");
                    break;
                }


            } while (opcao != 0);


        }
    }
}