using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetores
            string[] nome = new string[2];
            string[] sexo = new string[2];
            int[]    idade = new int[2];
            double[] peso = new double[2];
            double[] altura = new double[2];



            //variáveis
            int escolha;
            int opcao;
            int quantidadeM;
            int quantidadeF;
            int somaIdadeF;
            int somaIdadeM;
            int contador;


            // valor incremento      
            quantidadeM = 0;
            quantidadeF = 0;
            somaIdadeF = 0;
            somaIdadeM = 0;
            contador = 0;

            //lógica com "for"


            do //do 1
            {
                Console.WriteLine("-------------menu------------");
                Console.WriteLine("1 - Cadastrar uma pessoa");
                Console.WriteLine("2 - Listar as pessoas");
                Console.WriteLine("0 - Sair");
                escolha = int.Parse(Console.ReadLine());

             switch(escolha){
                 case 1:
                    do{
                 Console.WriteLine("Qual seu Sexo");
                 Console.WriteLine("Selecione uma das opções:");
                 Console.WriteLine("1 - Masculino");
                 Console.WriteLine("2 - Feminino");
                 opcao = int.Parse(Console.ReadLine());

                    switch(opcao){
                    
                     case 1:
                        contador = 0;
                       sexo[contador] = "M";
                       somaIdadeM += idade[contador];
                       contador++;
                     break;
                     case 2:
                        contador = 0;
                        sexo[contador] = "F";
                        somaIdadeF += idade[contador];
                        contador++;
                     break;
                     default:
                     Console.WriteLine("Opção Inválida, digite 1 ou 2");
                     break;
            

                    }while(opcao != 1 && opcao != 2); 
                    
                    break

            case 2:
                    
            if(sexo[contador] == "M"){
            contador = 0;
            quantidadeM++;
            }
            else{
            quantidadeF++;
            }

            if (escolha == 2)
            {
            Console.WriteLine($"O total de homens é de:{quantidadeM} e o total de Mulheres é de: {quantidadeF}");
            Console.WriteLine($"A Média de idade dos homens é de {somaIdadeM/quantidadeM} e das mulheres é de {somaIdadeF/quantidadeF}");

            for(int i = 0; i < 2; i++){
            Console.WriteLine($"Nome: {nome[i]}, sexo: {sexo[i]} possui o imc:{peso[i]/(altura[i]*altura[i])}");
            }


            }

            }


            }while(escolha != 0); //fim - do 1



        

        }
    }
}
