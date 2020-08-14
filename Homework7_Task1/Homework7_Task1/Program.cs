using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Task1
{
    class Program
    {
        static void Calculate(int a, int b, int c)
        {
            double z = a / (double)5;
            double i = b / (double)5;
            double j = c / (double)5;
            Console.WriteLine("{0} {1} {2} " , z, i, j);
        }
        static void Main(string[] args)
        {
            Calculate(15, 20, 30);
            Console.ReadKey();
        }
    }
}
