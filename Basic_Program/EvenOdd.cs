﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class EvenOdd
    {
        public static void evenodd()
        {
            Console.Write("Check whether a number is even or odd :\n");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int r = n % 2;

            if (r == 0)
            {
                Console.WriteLine("{0} is an even integer.\n", n);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer.\n", n);

            }
            Console.ReadLine();
        }
    }
}
