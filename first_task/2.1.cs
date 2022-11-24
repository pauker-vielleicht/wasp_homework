using System;

namespace example
{
    class Program
    { 
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string s = "";
            while ( num != 0 )
            {
                s = (num & 1).ToString() + s;
                num >>= 1;
            }
            Console.WriteLine(s);
        }
    }
}