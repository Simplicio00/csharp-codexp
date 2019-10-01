using System;

namespace each_240919
{
    class Program
    {
        static void Main(string[] args)
      {
            string[] nome = new string[10];
            nome [0] = "Carlos";
            nome [1] = "Ronaldo";

            foreach (var item in nome)
            {
               if(!string.IsNullOrEmpty(item)){
               Console.WriteLine(item);
                }
            }//fim foreach
            
            int[] numeros = new int [10];
            numeros[0] = 100;
            numeros[1] = 200;

            foreach (var item in numeros)
            {
                if(item != 0){
                 Console.WriteLine(item);
                }
            }
        }
    }
}


     