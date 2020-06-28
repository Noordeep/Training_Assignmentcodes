using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class GreatestOfTheThree
    {
        static void Main(String[] s)
        {
            int num1, num2, num3;
            Console.WriteLine("Please provide us with 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide us with 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide us with 3rd number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 == num2) && (num1 == num3) && (num2 == num1) && (num2 == num3) && (num3 == num1) && (num3 == num2))
                Console.WriteLine("The numbers {0},{1} and {2} are equal.", num1, num2, num3);
            if ((num1 > num2) && (num1 > num3))
                Console.WriteLine("{0} is the greatest.", num1);
            if ((num2 > num1) && (num2 > num3))
                Console.WriteLine("{0} is the greatest.", num2);
            if ((num3 > num1) && (num3 > num2))
                Console.WriteLine("{0} is the greatest.", num3);
            Console.ReadKey();
        }
    }
}
