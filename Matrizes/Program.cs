using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            int count = 0;

            Console.Write("Qual é a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];


            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers: " + cont);




        }
    }
}