using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixA(10, 12);
        }
        public static void MatrixA(int a, int b)
        {
            string[,] matrix = new string[a,b];
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rnd.Next(2).ToString();
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write('\n');
            }
            Console.ResetColor();
        }
    }
}
