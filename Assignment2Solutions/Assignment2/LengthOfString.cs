using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class LengthOfString
    {
        static void Main(String[] r)
        {
            String str;
            Console.WriteLine("Please enter any string:");
            str = Console.ReadLine();
            Console.WriteLine("You have entered a string of '{0}' number of characters.", str.Length);
            Console.ReadKey();
        }
    }
}
