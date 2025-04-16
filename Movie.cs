using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaces_Brown_jaylen
{
    internal class Movie : IGenre
    {   //properties for the class
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        //constructer that sets Esrb Genre Title
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
        //method that says the movie is starting when called
        public void PlayMovie() 
        {
            Console.WriteLine($"{Title} is starting");
        }
        //method the discribes a movie with Title genre Esrb when called
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}";
        }
    }
}
