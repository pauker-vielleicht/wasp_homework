using System;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine()),
                left = size,
                right = 1;

            int[,] ar = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int l = left; l < size; l++)
                {
                    Console.Write(l.ToString() + ' ');
                }
                for (int r = size; r >= right; r--)
                {
                    Console.Write(r.ToString() + ' ');
                }
                left--;
                right++;
                Console.WriteLine();
            }
        }
    }
}