using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Task4
{
    class Program
    {
        public static int Factr(int N)
        {
            int result;

            if (N == 1) return 1;
            result = Factr(N - 1) * N;
            return result;
        }

        static void Main(string[] args)
        {
            int f = Factr(3);
            Console.WriteLine(Factr(3));
            Console.ReadKey();
        }
    }
}
