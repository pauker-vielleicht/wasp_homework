using System;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] data = s.Split(' ');
            string array = Console.ReadLine();
            string[] ar = array.Split(' ');


            int size = Convert.ToInt32(data[0]);

            double p = Convert.ToInt32(data[1]),
                   sum = 0;

            for (int i = 0; i < size; i++)
            {
                double temp = Convert.ToInt32(ar[i]);
                sum += Math.Pow(temp, p);
            }

            Console.WriteLine(Math.Exp(Math.Log(sum)/p));

        }
    }
}