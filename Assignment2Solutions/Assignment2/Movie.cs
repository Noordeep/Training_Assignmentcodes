using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Movie
    {
        int id;
        string name;
        double duration;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Duration { get => duration; set => duration = value; }

        public void PrintMovieDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Duration:" + duration);
        }
    }
}
