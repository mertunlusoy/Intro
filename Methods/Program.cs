﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(3, 4);
            //Console.WriteLine(result);

            //int number1;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);   
            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(2, 5, 8, 1, 15));


            Console.ReadLine();
        }
        //static void Add()
        //{
        //    Console.WriteLine("Added!");
        //}
        //static int Add2(int number1 = 3, int number2 = 4)
        //{
        //    var result = number1 + number2;
        //    return result;
        //}
        //static int Add3(out int number1, int number2)
        //{
        //    number1 = 50;
        //    return number1 + number2;
        //}

        //static int Multiply(int number1,int number2)
        //{
        //    return number1 * number2;
        //}
        //static int Multiply(int number1, int number2,int number3)
        //{
        //    return number1 * number2 * number3;
        //}
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
