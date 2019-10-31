using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pract_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine((4 * Math.Log10(c) - d / 2 + 23) / Math.Pow(a, 2) - 1);
            Console.ReadKey(); 
        }
    }
}
