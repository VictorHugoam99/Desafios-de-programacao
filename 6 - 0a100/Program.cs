using System;

namespace _0a100
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            System.Console.WriteLine("Sequencia de números de 0 a 100: ");
            System.Console.WriteLine("Aperte ENTER para começar a contagem!! ");
            Console.ReadLine();
            System.Console.WriteLine();

            for (int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
