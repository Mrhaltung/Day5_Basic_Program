using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            //char ok;
            //ok = 'n';
            //do
            //{

                Console.WriteLine("Enter your Choice : \n1.Flip Coin. \n2.Leap Year. \n3.Harmonic Number. \n4.Power of 2. \n5.Prime Factor. \n6.Even or Odd. \n7.Divisor and Dividend. \n8.Large Number. \n9.Check Vowel or Consonant.\n10.Swap.");
                int key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                case 1:
                      FlipCoin.flipcoin();
                      break;
                case 2:
                      LeapYear.leapyear();
                      break;
                case 3:
                      HarmonicNo.harmonicNo();
                      break;
                case 4:
                    PowerofTwo.poweroftwo();
                    break;
                case 5:
                    PrimeFactor.primefactor();
                    break;
                case 6:
                    EvenOdd.evenodd();
                    break;
                case 7:
                    DivisorDividend.divisiordividend();
                    break;
                case 8:
                    LargeNo.largeno();
                    break;
                case 9:
                    Alphabet.alphabet();
                    break;
                case 10:
                    Swapping.swap();
                    break;
                default:
                      Console.WriteLine("Number is invalid.");
                      break;
                }
            //} while (ok);
        }
    }
}

