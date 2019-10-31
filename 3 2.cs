using System;

namespace kek3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, s = 0;
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                s += 1 / Math.Pow(n, 2);
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
