using System;
using System.Collections.Generic;

namespace _25_TresVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o tamanho do seu vetor: ");
            int v = int.Parse(Console.ReadLine());
            
            int[] V = new int [v];
            int[] V1 = new int[v];
            int[] total = new int [v+v];
            
            Random random = new Random ();
            Random random1 = new Random ();

            for (int i = 0; i < v; i++) 
            {
                V[i] = random.Next (v);
                V1[i] = random1.Next (v);
                total[i] = V[i] + V1[i];
            }
            
            foreach (var go in V) 
            {
                System.Console.Write ($"{go} ");
            }
            
            System.Console.WriteLine ();
            
            foreach (var go1 in V1)
            {
                System.Console.Write ($"{go1} ");
            }
            System.Console.WriteLine ();
            Console.ReadLine ();
            
            foreach (var item in total) 
            {
                System.Console.Write ($"{item} ");
            }
        }
    }
}