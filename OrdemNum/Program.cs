using System;

namespace OrdemNum {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Digite o primeiro número: ");
            string numero = Console.ReadLine ();
            Console.Clear ();
            System.Console.WriteLine ("Digite o segundo número: ");
            string numero1 = Console.ReadLine ();
            System.Console.WriteLine ("Digite o terceiro número: ");
            string numero2 = Console.ReadLine ();

            int compare = string.Compare (numero, numero1, numero2);

            if (compare < 0) {
                System.Console.WriteLine ($"{nome} \n{nome1}");
            } else {
                System.Console.WriteLine ($"{nome1} \n{nome}");
            }
        }
    }
}
