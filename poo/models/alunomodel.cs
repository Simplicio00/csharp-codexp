using System;

namespace poo.models
{
    public class alunomodel
    {
        
        public string Nome { get; set; }

        public string Curso { get; set; }

        public int Rg { get; set; }

        public int Idade { get; set; }

        public float Altura { get; set; }
   

        public void CadastrarAluno(){

            System.Console.WriteLine("Insira o nome do aluno");
            Nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira o nome do curso");
            Curso = Console.ReadLine();

            System.Console.WriteLine("Insira o RG");
            Rg = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Insira a idade");
            Idade = int.Parse(Console.ReadLine());

        }


        public void ListarAluno(){

            
            Console.WriteLine($@"
            Nome: {Nome}
            Curso: {Curso}
            RG: {Rg}
            Idade: {Idade}
            ");

        }

        public void IraoBanheiro(){
        
        Console.WriteLine("O aluno foi ao banheiro");
        
        } 
   
    }
}