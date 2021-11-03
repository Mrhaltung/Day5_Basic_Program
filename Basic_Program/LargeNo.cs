using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class LargeNo
    {
        public static void largeno()
        {
            
            Console.Write("Find the largest of three numbers:\n");
            
            Console.Write("Input the 1st number :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.Write("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three.");
                }
            }
            else if (n2 > n3)
                Console.Write("The 2nd Number is the greatest among three. ");
            else
                Console.Write("The 3rd Number is the greatest among three.");
            Console.ReadLine();
        }
    }
}
