using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager movie1 = new MovieManager();
            movie1.CreateMovie();
            Console.ReadKey();
        }
    }
}
