using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Doctor
    {
        public Doctor()
        {
            experience = 1;
        }
        //public Doctor(string name, int age, float experience, long phonenumber)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.experience = experience;
        //    this.phoneNumber = phonenumber;
        //}
        ~Doctor()
        {
            Console.WriteLine("Bye from Dr. {0}",name);
        }
        string name;
        int age;
        float experience;
        long phoneNumber;

        public void IntakeValues()
        {
            Console.WriteLine("Please enter your NAME:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your AGE:");
            age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your EXPERIENCE:");
            //experience = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your PHONE-NUMBER:");
            phoneNumber = long.Parse(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Doctor Details");
            Console.WriteLine("---------------");
            Console.WriteLine("NAME: "+ name);
            Console.WriteLine("AGE: "+ age);
            Console.WriteLine("EXPERIENCE: "+ experience);
            Console.WriteLine("PHONE-NUMBER: "+ phoneNumber);

        }
    }
}
