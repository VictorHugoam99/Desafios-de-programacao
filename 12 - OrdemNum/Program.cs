using System;

namespace OrdemNum {
    class Program {
        static void Main(string[] args)
        {
        int a = 5;
        int b = 6;
        int c = 5;

        int ab = a.CompareTo(b);
        int ba = b.CompareTo(a);
        int ca = c.CompareTo(a);

        Console.WriteLine(ab);
        Console.WriteLine(ba);
        Console.WriteLine(ca);
        }
    }
}
