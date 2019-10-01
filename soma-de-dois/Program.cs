using System;

namespace soma_de_dois
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine(boasVindas());

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());            

            int resultadoDaSoma = SomaDeDoisNumeros(numero1, numero2);

            Console.WriteLine(resultadoDaSoma);
            

            }// fim da main

            ///<summary>Efetua a soma de dois números: </summary>
            /// <paran name="a"> Primeiro valor inteiro </paran>
            /// <paran name="b"> Segundo valor inteiro </paran>
            /// <return> Retorna a soma de A e B </return>
            /// 
            public static int SomaDeDoisNumeros(int a, int b){
                int soma = a + b;
                return soma;            
                }// fim função


            /// <summary>Retorna o texto de boas vindas</summary>
            public static string boasVindas(){
                return "Bem vindo ao senai";
            }//fim função

            }
            }