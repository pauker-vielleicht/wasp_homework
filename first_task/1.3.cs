using System;
using System.Xml.Schema;

namespace example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] data = new int[2, 3];
            for (int c = 0; c < 3; c++)
            {
                string s = Console.ReadLine();
                string[] temp = s.Split();
                int i, j;
                (i, j) = (Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]));
                (data[0, c], data[1, c]) = (i, j);
            }
            int x1 = data[0, 0],
                y1 = data[1, 0],
                x2 = data[0, 1],
                y2 = data[1, 1],
                x3 = data[0, 2],
                y3 = data[1, 2];

            /*(x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0)
            (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0)
            (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0)*/
            int Xmax = Math.Max(Math.Max(x1, x2), x3),
                Ymax = Math.Max(Math.Max(y1, y2), y3);

            for (int i = 0; i <= Ymax; i++)
            {
                for (int j = 0; j <= Xmax; j++)
                {
                    int a = (x1 - j) * (y2 - y1) - (x2 - x1) * (y1 - i),
                        b = (x2 - j) * (y3 - y2) - (x3 - x2) * (y2 - i),
                        c = (x3 - j) * (y1 - y3) - (x1 - x3) * (y3 - i);

                    if ( (a >= 0 && b >= 0 && c >= 0) || ( a <= 0 && b <= 0 && c <= 0))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}