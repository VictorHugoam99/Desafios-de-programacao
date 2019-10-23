using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra se o seu número é par ou ímpar!!");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            if (n % 2 == 0)
            {
                System.Console.WriteLine("Seu número é par ! ");
            }else {
                System.Console.WriteLine("Seu número é ímpar !");
            }
        }
    }
}
