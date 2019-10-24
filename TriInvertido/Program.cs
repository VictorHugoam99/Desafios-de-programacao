using System;

namespace TriInvertido
{
    class Program
    {
        static void Main(string[] args)
        {           
            System.Console.WriteLine("Triângulos");
            System.Console.WriteLine("Pressione ENTER p/ começar");
            Console.ReadLine();
            System.Console.WriteLine("Digite a altura do triângulo :");
            int h = int.Parse(Console.ReadLine());

            for (int i = h; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    System.Console.Write("+");
                }
                System.Console.WriteLine(" ");
            }
        }
    }   
}