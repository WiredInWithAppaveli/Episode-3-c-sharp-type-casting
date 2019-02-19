using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = 5.0;
            float c = 5.0f;
            decimal d = 5.0m;

            //Console.WriteLine("Integer " + a);
            //Console.WriteLine("Double " + b);
            //Console.WriteLine("Float " + c);
            //Console.WriteLine("Decimal " + d);

            //int castInt = a * (int)b;
            //double castDouble = b * (double)d;

            //Console.WriteLine("Casting Integer " + castInt);
            //Console.WriteLine("Casting Double " + castDouble);

            string x = "30.5";
            string y = "25.5";




            //decimal newX = Convert.ToDecimal(x);
            //double newY = Convert.ToDouble(y);
            //double xandY = (double)newX * newY;

            //Console.WriteLine("New X and Y " + xandY);



            Console.WriteLine("Enter a number!");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = num + num2;
            Console.WriteLine("total " + total);
        }
    }
}
