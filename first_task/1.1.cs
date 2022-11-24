using System;

namespace example
{
    class Program
    {
        public static int pow(int n, int power)
        {
            int res = 1;
            for (int i = 1; i <= power; i++)
            {
                res *= 10;
            }
            return res;
        }
        public static void Main(string[] args)
        {
           for ( int i = 1; i <= 9; i++)
           {
               for (int j = i + 1; j <= 9; j++)
                {
                    for (int k = j + 1; k <= 9; k++)
                    {
                        for (int d = k + 1; d <= 9; d++)
                        {
                            Console.WriteLine(i * pow(10,3) + j * pow(10,2) + k * pow(10,1) + d);
                        }
                    }
                }
           }
        }
    }
}