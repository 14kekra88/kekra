using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number_x = double.Parse(Console.ReadLine());
            double number_a = double.Parse(Console.ReadLine());
            double number_t = double.Parse(Console.ReadLine());
            double number_q = double.Parse(Console.ReadLine());
            const double e = 3.6;
            if (-2 >= number_x && number_x >= 2)
            {
                Console.WriteLine(Math.Pow(number_x, 2) - number_t * number_q * number_x);
            }
            else if (number_x > 2)
            {
                Console.WriteLine(Math.Pow(e, number_x + 1) + Math.Sqrt(Math.Pow(number_x, 3)));
            }
            else if (number_x < -2)
            {
                Console.WriteLine(Math.Sin(Math.Pow(number_x, 2)) + Math.Log10(Math.Abs(number_x)));
            }
            else
            {
                Console.WriteLine("Произошла ошибка");
            }
            Console.ReadKey();
        }
    }
}

