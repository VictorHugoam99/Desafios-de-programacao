using System;
using System.Collections.Generic;


namespace _23_Vetores10 
{
    class Program {
        static void Main ()
        {
            int[] V = new int[10];
            
            Random random = new Random ();  
            List<int> lista = new List<int> ();
            
            for (int i = 0; i < 10; i++) 
            {
                V[i] = random.Next (0, 10);
            }
            foreach (int item in V) 
            {
                lista.Add (item);
            }
            System.Console.Write ("Itens: ");
            foreach (int item in lista) 
            {
                System.Console.Write ($"{item} ");
            }
            int total = 0;
            for (int i = 0; i < 10; i++) 
            {
                total += V[i];
            }
            System.Console.WriteLine ($"\n Soma total: {total}");
        }
    }
}

