using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class DivisorDividend
    {
        public static void divisiordividend()
        {
            Console.WriteLine("Enter the value of Dividend and Divisor.");
            int d = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());

            int r;
            float q = Math.DivRem(d, D, out r);

            Console.WriteLine("Dividend:{0} Divisor:{1}", d, D);
            Console.WriteLine("Quotient = " + q);
            Console.WriteLine("Remainder = " + r);
            Console.ReadLine();
        }
    }
}
