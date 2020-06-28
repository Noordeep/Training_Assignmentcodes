using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class DivisibleBy7
    {
        static void Main(String[] a)
        {
            int num;
            Console.WriteLine("Please enter a number to check the divisibility by 7: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0)
                Console.WriteLine("The number {0}, provided by you, is divisible by 7",num);
            else
                Console.WriteLine("The number {0}, provided by you, is not divisible by 7", num);
            Console.ReadKey();
        }
    }
}
