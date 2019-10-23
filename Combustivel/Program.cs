using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantidade de litros de combustível gastos em uma viagem: ");
            System.Console.WriteLine("Digite o tempo gasto em sua viagem: ");
            double tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade média de sua viagem: ");
            double velocidade = double.Parse(Console.ReadLine());

            double dist =  tempo*velocidade;
            System.Console.WriteLine($"A distância percorrida é {dist}");

            double gasosa = dist / 12;
            System.Console.WriteLine($"Voce gastou {gasosa} litros de gasolina");
        }
    }
}
