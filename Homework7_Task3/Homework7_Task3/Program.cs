using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Task3
{
    class Program
    {
        static void CalculateCredit (int payment)
        {
            int debtCredit = 0;
            int overCredit = 0;

            Console.Write("Введіть суму кредиту : ");
            int allCredit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть суму платежу : ");
            int myPayment = Convert.ToInt32(Console.ReadLine()); 

            if(myPayment == allCredit)
            {
                Console.WriteLine("Заборгованість відсутня ");
            }
            else if (myPayment < allCredit)
            {
                debtCredit = allCredit - myPayment;
                Console.WriteLine("Наявна заборгованість {0} ", debtCredit);
            }
            else if (myPayment > allCredit)
            {
                overCredit =  myPayment - allCredit;
                Console.WriteLine("Наявна переплата {0} ", overCredit);
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CalculateCredit(400);

            Console.ReadKey();
        }
    }
}
