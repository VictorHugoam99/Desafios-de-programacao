using System;

namespace _120a300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Sequencia de números de 120 a 300: ");
            System.Console.WriteLine("Aperte ENTER para começar a contagem!! ");
            Console.ReadLine();
            System.Console.WriteLine();

            for (int i = 120; i <= 300; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
