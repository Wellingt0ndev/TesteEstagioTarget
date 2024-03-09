/*3) Descubra a lógica e complete o próximo elemento:
a) 1, 3, 5, 7, ___
b) 2, 4, 8, 16, 32, 64, ____
c) 0, 1, 4, 9, 16, 25, 36, ____
d) 4, 16, 36, 64, ____
e) 1, 1, 2, 3, 5, 8, ____
f) 2,10, 12, 16, 17, 18, 19, ____
*/

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Próximo elemento de A = "+ A());
            Console.WriteLine("Próximo elemento de B = "+ B());
            Console.WriteLine("Próximo elemento de C = "+ C());
            Console.WriteLine("Próximo elemento de D = "+ D());
            Console.WriteLine("Próximo elemento de E = "+ E());
            Console.WriteLine("Próximo elemento de F = "+ F());
                    
        }

        public static int A()
        {
            List<int> a = new List<int>(){1,3,5,7};
            int proximo = a[a.Count() - 1]+ 2;
            return proximo;
        }

        public static int B()
        {
            List<int> a = new List<int>() { 2,4,8,16,32,64};
            int proximo = a[a.Count() - 1] * 2;
            return proximo;
        }

        public static int C()
        {
            List<int> a = new List<int>() { 0,1,4,9,16,25,36};
            int proximo = (int)Math.Pow(a.Count(),2);
            return proximo;
        }
        public static int D()
        {
            List<int> a = new List<int>() { 4, 16, 36, 64 };
            int dobro = a.Count() * 2;
            int proximo = (int)Math.Pow(dobro + 2, 2);
            return proximo;
        }
        public static int E()
        {
            List<int> a = new List<int>() { 1, 1, 2, 3, 5, 8 };
            int proximo = a[a.Count()-1] + a[a.Count() - 2];
            return proximo;
        }

        public static int F()
        {
            List<int> a = new List<int>() { 2, 10, 12, 16, 17, 18, 19 };
            int proximo = 200;
            return proximo;
            //proximo numero que começa com a letra D.
        }
    }
}
