﻿/*1) Observe o trecho de código abaixo:
int INDICE = 13, SOMA = 0, K = 0;
enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}
imprimir(SOMA);
 
 */
namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while(k < indice)
            {
                k++;
                soma += k;
            }

            Console.WriteLine("O valor da soma é: "+ soma);
        }
    }
}
