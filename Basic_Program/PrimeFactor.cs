using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class PrimeFactor
    {
        public static void primefactor()
        {
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.WriteLine("Factors are " + 2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine("Factors are " + i + " ");
                    n /= i;
                }
            }
            if (n > 2)
            {
                Console.WriteLine("Factors are " + n);
            }
            else
            {
                Console.WriteLine(n + " is not having any factors. ");
            }
            Console.ReadLine();
        }
    }
}
