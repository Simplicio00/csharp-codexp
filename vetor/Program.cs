using System;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string[] nomes = new string[3];  //vetor
            int contador = 0;  //variável

            while(contador <3){
                
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] =  Console.ReadLine();
                contador++;     //repetidor +1
            }

            contador = 0;

            while(contador<3){
                Console.WriteLine($"O nome na posição {contador}º é {nomes[contador]}");
                contador++;     //repetidor +1
            }       
        }
    }
}
