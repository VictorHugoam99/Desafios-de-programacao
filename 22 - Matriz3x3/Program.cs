using System;


namespace _22_Array3x3 {
    class Program {
        static void Main (string[] args) {
            int soma = 0;
            int[, ] V = new int[3, 3];

            Random random = new Random ();

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    V[i, j] = random.Next (0, 10);
                }
            }
            for (int k = 0; k < 3; k++) {
                for (int o = 0; o < 3; o++) {
                    soma += V[k, o];
                }
            }

            System.Console.WriteLine ($"Soma dos números aleatórios: {soma}");
        }
    }
}