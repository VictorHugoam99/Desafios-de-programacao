using System;

namespace AlgoritmosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite os dados do retângulo:");
            System.Console.Write("Base: ");
            double b = double.Parse(Console.ReadLine());
            System.Console.Write("Altura: ");
            double h = double.Parse (Console.ReadLine());
        
            Console.Clear();
            double Perimetro = 2 * b + 2 * h;
            System.Console.WriteLine($"O perímetro é: {Perimetro}");

            double Area = b*h;
            System.Console.WriteLine($"A área é: {Area}");

            double Diagonal = b * b + h * h;
            Diagonal = Math.Sqrt(Diagonal);
            System.Console.WriteLine($"A diagonal é: {Diagonal}");
        }
    }
}
