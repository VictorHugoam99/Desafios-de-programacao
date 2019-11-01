using System;

namespace NumImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Sequencia de números ímpares de 0 a 10: ");
            System.Console.WriteLine("Aperte ENTER para começar a contagem!! ");
            Console.ReadLine();
            System.Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
