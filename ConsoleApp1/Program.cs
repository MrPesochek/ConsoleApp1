using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void MatrixB(int n, int h)
        {
            int[,] matrix = new int[n, h];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    matrix[i, j] = rnd.Next(2);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write('\n');
            }
            Console.ResetColor();
        }
        public static void PrintMyName()
        {
            Console.WriteLine("Песчаный Максим Кириллович 1000.-7.=993");
        }

        public static void PrintmyName()
        {
            Console.WriteLine("Fomin Daniil Antonovich\n10.3\nJuly, 28");
        }

        static void Main(string[] args)
        {
            MatrixB(10, 12);
            PrintMyName();
        }
    }
}
