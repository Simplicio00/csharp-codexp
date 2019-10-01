using System;
using poo.models;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            alunomodel aluno1 = new alunomodel();

             Console.Clear();

            aluno1.CadastrarAluno();

            aluno1.ListarAluno();

            aluno1.IraoBanheiro();

        }
    }
}