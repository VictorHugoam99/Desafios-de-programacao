using System;

namespace ValoresAeB
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
            System.Console.WriteLine("Digite dois valores, um valor para A e outro para B:");
            System.Console.WriteLine("Valor A :");
            double A = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Valor B");
            double B = double.Parse(Console.ReadLine());
            System.Console.WriteLine();

            A += B;
            B = A - B;
            A -= B;

            System.Console.WriteLine($"O novo valor de A é: {A}");
            System.Console.WriteLine($"O novo valor de B é: {B}");
            System.Console.WriteLine();
            
        }
    }
}
