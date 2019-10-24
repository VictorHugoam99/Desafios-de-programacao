using System;

namespace Multi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra se o seu número é multiplo de 3:");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            if (n % 3 == 0)
            {
                System.Console.WriteLine("Seu número é múltiplo de 3 ! ");
            }else {
                System.Console.WriteLine("Seu número não é múltiplo de 3 !");
            }
        }
    }
}
