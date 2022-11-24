using System;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine()); 
            string s = Console.ReadLine();
            string[] ar = s.Split(' ');

            for ( int i = 0; i < size; i++)
            {
                for ( int j = 0; j < size - 1; j++)
                {
                    if (Convert.ToInt32(ar[j]) > Convert.ToInt32(ar[j + 1]))
                    {
                        string temp = ar[j + 1];
                        ar[j + 1] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ar[k - 1]);
        }
    }
}