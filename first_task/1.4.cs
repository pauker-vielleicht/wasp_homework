using System;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            for (int u = 0; u < size; u++)
            {
                for (int l = 0; l <= u; l++)
                {
                    int k = l;
                    int res = 1;
                    if (k > u - k)
                        k = u - k;
                    for (int i = 0; i < k; ++i)
                    {
                        res *= (u - i);
                        res /= (i + 1);
                    }
                    Console.Write(Convert.ToString(res) + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}