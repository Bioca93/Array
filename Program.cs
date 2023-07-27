using System;
using System.Collections.Generic;

namespace ArrayEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays Uma Dimensão
            int tamanho = 4;

            int[] x = new int[tamanho];
            int[] y = new int[5] {100,200,300,0,0};
            int[] z = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] w = { 1, 100, 501 };


            x[3] = 1;
            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);
            Console.WriteLine(x[3]);
            Console.WriteLine();

            x = new int[20];

            x[18] = 222;
            int indice18 = x[18];

            Console.WriteLine(x[16]);
            Console.WriteLine(x[17]);
            Console.WriteLine(indice18);
            Console.WriteLine(x[19]);

            Console.WriteLine();
            Console.WriteLine(y[2]);
            Console.WriteLine();
            Array.Sort(y);
            Array.Reverse(y);
            Console.WriteLine(y[0]);
            Console.WriteLine("Tamanho de y: " + y.Length);
            Console.WriteLine();

            int[] p = new int[y.Length - 2]; // 0,0,0,0
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            Console.WriteLine();

            // Arrays Duas Dimensões
            int[,] a = new int[2,3];
            // 0 0 0
            // 0 0 0

            int[,] b = new int[2, 3]
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            // 1 2 3
            // 4 5 6

            b[1, 1] = 111;

            Console.WriteLine(b[0,0]);
            Console.WriteLine(b[0,1]);
            Console.WriteLine(b[0,2]);
            Console.WriteLine(b[1,0]);
            Console.WriteLine(b[1,1]);
            Console.WriteLine(b[1,2]);
            Console.WriteLine();

            // List 
            List<int> n = new List<int>();
            int[] N = new int[0];

            n.Add(234);
            Console.WriteLine(n[0]);
            Console.WriteLine("Tamanho " + n.Count);

            n.Add(333);
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine("Tamanho " + n.Count);

            n.RemoveAt(0);
            Console.WriteLine(n[0]);
            Console.WriteLine("Tamanho " + n.Count);
        }
    }
}
