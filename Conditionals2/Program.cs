using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 21;
            //Console.WriteLine(number == 11 ? "Sayı 11'e eşittir." : "Sayı 11'e eşit değildir.");
            //if (number == 10)
            //{
            //    Console.WriteLine("Sayı 10'a eşittir.");
            //}
            //else if (number == 12)
            //{
            //    Console.WriteLine("Sayı 12'ye eşittir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 10 veya 12 değildir.");
            //}

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 12:
            //        Console.WriteLine("Number is 12");
            //        break;
            //    case 11:
            //        Console.WriteLine("Number is 11");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10,11 or 12");
            //        break;

            //}

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0 and 100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101 and 200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            Console.ReadLine();
        }
    }
}
