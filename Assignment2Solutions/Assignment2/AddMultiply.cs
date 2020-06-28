using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{ 
    class AddMultiply
    {
        void addition(int n1, int n2)
        {
            int sum;
            sum = n1 + n2;
            Console.WriteLine("Sum: " + sum);
        }

        void multiplication(int n1,int n2)
        {
            double product;
            product = n1 * n2;
            Console.WriteLine("Product: " + product);
        }
        static void Main(String[] i)
        {
            int num1;
            int num2;
            Console.WriteLine("Please enter 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            AddMultiply addMultiply = new AddMultiply();
            addMultiply.addition(num1,num2);
            addMultiply.multiplication(num1,num2);


            

            Console.ReadKey();
        }
    }
}
