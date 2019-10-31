using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = 0, schet = 0, arif = 0;
            for (int i = -5; i <= 51; i++)
            {
                schet++;
                summa += i;
            }
            Console.WriteLine(summa / schet);
            Console.ReadKey();
        }
    }
}
