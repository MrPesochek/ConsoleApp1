using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void MatrixB(int n, int h)
        {
            int[,] matrix = new int[n, h];
            Random rnd = new Random();
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < h; j++)
                {
                    matrix[i, j] = rnd.Next(2);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write('\n');
            }
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            MatrixB(10, 12);
        }
    }
}
