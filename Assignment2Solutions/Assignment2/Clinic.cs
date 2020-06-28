using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Clinic
    {
        static void Main(String[] n)
        {
            String name;
            int age;
            float experience;
            long phoneNumber;
           
           
            Doctor doctor=new Doctor();
            doctor.IntakeValues();
            doctor.PrintDetails();
            doctor =null;
            GC.Collect();
            Console.ReadKey();

        }
    }
}
