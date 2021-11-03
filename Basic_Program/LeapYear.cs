using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class LeapYear
    {
        public static void leapyear()
        {

            Console.WriteLine("Enter Year (YYYY) :: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                    {
                        Console.WriteLine("This is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("This is not leap year");
                    }

                }
                else
                {
                    Console.WriteLine("This is a leap year");
                }

            }
            else
            {
                Console.WriteLine("This is not leap year");
            }
            Console.ReadLine();
        }
    }
}
