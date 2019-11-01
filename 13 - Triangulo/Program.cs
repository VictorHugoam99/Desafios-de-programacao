using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a base do seu triângulo: ");
            double lado3 = double.Parse(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine("Digite o tamanho do primeiro lado: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine("Digite o tamanho do segundo lado: ");
            double lado2 = double.Parse(Console.ReadLine());

            if (lado1 != 0 && lado2 != 0 && lado3 != 0)
            { 
                if ((lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado1 + lado3 > lado2))
                {
                    System.Console.WriteLine("Seu  triângulo é válido");
            } else 
            {
                System.Console.WriteLine("Os lados não fazem parte de um triângulo");
            }
                }else 
                {
                    System.Console.WriteLine("Lado 0 inválido.");
                }
        }
    }
}
