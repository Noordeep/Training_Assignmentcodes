using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ToUpperToLower
    {
        static void Main(String[] t)
        {
            String str;
            Console.WriteLine("Please enter a String:");
            str = Console.ReadLine();
            Console.WriteLine("Your string in 'UPPERCASE':" + str.ToUpper());
            Console.WriteLine("Your string in 'lowercase':" + str.ToLower());
            Console.ReadKey();
        }
    }
}
