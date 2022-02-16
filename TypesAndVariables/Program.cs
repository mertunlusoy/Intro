using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 55;
            long number2 = 197;
            short number3 = 502;
            byte number4 = 7;
            bool condition1 = true;
            char character = 'a';
            double number5 = 5.6;
            decimal number6 = 10.7m;
            var number7 = "baba";
        
            
            Console.WriteLine("Birinci sayı: {0}",number1);
            Console.WriteLine("İkinci sayı: {0}", number2);
            Console.WriteLine("Üçüncü sayı: {0}", number3);
            Console.WriteLine("Dördüncü sayı:{0}", number4);
            Console.WriteLine("Birinci kondisyon:{0}", condition1);
            Console.WriteLine("Birinci karakter:{0}", character);
            Console.WriteLine("Birinci ondalıklı sayı:{0}", number5);
            Console.WriteLine("Deneme:{0}", number6);
            Console.WriteLine("Değişken:{0}", number7);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
