using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaces_Brown_jaylen
{
    internal class Class1 : IGenre
    {   //properties for the class
        public string Esrb { get ; set ; }
        public string Genre { get ; set ; }
        public string Title { get ; set ; }
        //constructer that sets Esrb Genre Title
        public Class1(string esrbParam, string genreParam, string titleParam)
        { 
            Esrb = esrbParam;
            Genre = genreParam; 
            Title = titleParam;
        }
        //method that says the game is starting when called
        public void playgame() 
        {
            Console.WriteLine($"{Title} is starting");
        }
        //method the discribes a game with Title genre Esrb when called
        public string Describe()
        {
            return $"{Title}is a {Genre} game, rated {Esrb}";
        }
    }
}
