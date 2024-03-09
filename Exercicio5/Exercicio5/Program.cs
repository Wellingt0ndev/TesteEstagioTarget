//5) Escreva um programa que inverta os caracteres de um string.
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            string palavraInvertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }
            Console.WriteLine(palavraInvertida);
        }
    }
}
