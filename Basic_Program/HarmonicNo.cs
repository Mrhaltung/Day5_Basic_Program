using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class HarmonicNo
    {
        public static void harmonicNo()
        {
            float i;
            double s = 0;
            Console.WriteLine("Enter the number : ");
            float n = int.Parse(Console.ReadLine());
            //float div = 0;

            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }

            Console.WriteLine(" \n Harmonic Number. " + s);
            Console.ReadLine();
        }
    }
}
