using System;

namespace ConvTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Conversão de Celsius p/ Fahrenheit: ");
            System.Console.WriteLine("Digite a  temperatura que será convertida p/ Fahrenheit: ");
            double temp = double.Parse(Console.ReadLine());

            double F = (temp * 9) / 5 + 32;
            System.Console.WriteLine($" A temperatura em Fahrenheit é: {F}");
        }
    }
}
