using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaces_Brown_jaylen
{   // makes a constructor with Esrb Genre Title
    internal interface IGenre
    {
        //makes automatic propertys
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }
       
        //makes the describe method
        public string Describe();

    }
}
