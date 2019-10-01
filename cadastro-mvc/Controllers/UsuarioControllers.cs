using System;
using System.Collections.Generic;
using cadastro_mvc.Models;

namespace cadastro_mvc.Controllers
{       

        /// <summary>Método de cadastro de usuários</summary>
    public class UsuarioControllers
    {

        List<UsuarioModel> ListaDeUsuarios = new List<UsuarioModel>();

        public void CadastroUsuario(){
            
            Console.WriteLine("Digite o Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informe seu email: ");            
            string Email = Console.ReadLine();
            Console.WriteLine("Informe sua senha: ");
            string Senha = Console.ReadLine();


            //Instanciando o usuario
            UsuarioModel usuario = new UsuarioModel();

            usuario.Id =  ListaDeUsuarios.Count + 1;
            usuario.Nome = Nome;
            usuario.Email = Email;
            usuario.Senha = Senha;
            usuario.DataCriacao = DateTime.Now;

            ListaDeUsuarios.Add(usuario);
        
        }// fim cadastro usuário

        public void ListarUsuarios(){
        foreach (var item in ListaDeUsuarios){
            Console.WriteLine($"----------------------");            
            Console.WriteLine($"O usuario: {item.Nome}");   
            Console.WriteLine($"O ID: {item.Id}");        
            Console.WriteLine($"E-Mail: {item.Email}");          
            Console.WriteLine($"Data do Cadastro: {item.DataCriacao}");
            Console.WriteLine($"----------------------");             
        }// fim foreach
        }// fim ListarUsuarios

        public bool Logar(){
            System.Console.WriteLine("Insira o email");
            string email = Console.ReadLine();

            System.Console.WriteLine("Insira uma senha");
            string senha = Console.ReadLine();
            
            foreach (var item in ListaDeUsuarios)
            {
                if(item.Email == email && item.Senha == senha){
                    return true;     
            }//fim iff
            }// fim foreach
            return false;
            } //fim logar
    

    }
}