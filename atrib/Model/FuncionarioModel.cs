using System;
using System.Collections.Generic;

namespace atrib.Model
{
    public class FuncionarioModel : PessoaModel
    {

        public List<FuncionarioModel> listaDeFuncionarios = new List<FuncionarioModel>();

        public string Cargo { get; set; }

        public void Trabalhar(){
            System.Console.WriteLine("Vamos trabalhar?");
        } 

        public FuncionarioModel CadastroFuncionario(){

                FuncionarioModel funcionario = new FuncionarioModel();

                 Console.Clear();

                Console.WriteLine("Digite o nome do funcionário");
                funcionario.Nome = Console.ReadLine();

                Console.WriteLine("Digite a idade do funcionário");
                funcionario.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o cargo do funcionário");
                funcionario.Cargo = Console.ReadLine();


                funcionario.Nome = Nome;
                funcionario.Cargo = Console.ReadLine();

                return funcionario;

        }



        
    }
}