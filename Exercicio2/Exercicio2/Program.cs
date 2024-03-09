/*2) Dado a sequência de Fibonacci,onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos
2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,
informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence
ou não a sequência. 
 */
namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int anterior = 0;
            int atual = 1; 
            int proximo = 0;          

            while (proximo <= numero)
            {
                if (proximo == numero)
                {
                    Console.WriteLine($"{numero} pertence à sequência de Fibonacci!");                    
                    return;
                }
                proximo = anterior + atual;               
                anterior = atual;
                atual = proximo;
            }
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }
}


