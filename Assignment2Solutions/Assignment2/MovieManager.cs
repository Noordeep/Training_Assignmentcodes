using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MovieManager
    {
        Movie movie;
        public void CreateMovie()
        {
            movie = new Movie
            {
                Id = 101,
                Name = "3 Idiots",
                Duration = 3.00d
            };
            movie.PrintMovieDetails();
        }
    }
}
