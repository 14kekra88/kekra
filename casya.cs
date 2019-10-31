using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц");
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            double number_b = double.Parse(Console.ReadLine());
            switch (number_b)
            {
                case 1:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b + 11);
                    break;
                case 2:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 3:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 4:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 5:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                case 6:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 7:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 8:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 9:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 10:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 11:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                case 12:
                    Console.WriteLine(number_a - 1);
                    Console.WriteLine(number_b - 1);
                    break;
                default:
                    Console.WriteLine(Ошибка);
                    break;
            }
            Console.ReadKey();
        }
    }
}

