using System;

namespace LimiteSup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Escolha um número inteiro para ser seu limite superior: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.Write ("ENTER para começar");
            Console.ReadLine();
            System.Console.WriteLine();

            for (int i = 0; i <= x; i++)
            {
                if (i %2 != 0)
                {
                    System.Console.WriteLine($"N° {i}");
                }
            }
        }
    }
}
