using System;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string array = Console.ReadLine();
            string[] ar = array.Split(' ');
            string s = Console.ReadLine();
            string[] data = s.Split(':');

            int beg = Convert.ToInt32(data[0]) - 1, 
                end = Convert.ToInt32(data[1]) - 1, 
                step = Convert.ToInt32(data[2]);

            if ( step > 0)
            {
                for ( int i = beg; i <= end; i+= step)
                {
                    Console.Write(ar[i].ToString() + " ");
                }
            } else
            {
                for (int i = end; i >= beg; i += step)
                {
                    Console.Write(ar[i].ToString() + " ");
                }
            }
            
        }
    }
}