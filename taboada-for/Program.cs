using System;

namespace taboada_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            Console.WriteLine("Hello World!");


            float tabuada = float.Parse(Console.ReadLine());


            for(int contador =0; contador <=10; contador++)
            {
             Console.WriteLine($"{tabuada}X{contador} = {tabuada*contador}");
            }


        }
    }
}
