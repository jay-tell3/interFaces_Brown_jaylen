namespace interFaces_Brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //makes the myGame obj and sets the Esrb Title and genre
            Class1 myGame = new Class1("E", "fps", "Shell shocked");
            //calls and writes the Describe methed using the myGame obj to the console
            Console.WriteLine(myGame.Describe());
            //calls the PlayGame method
            myGame.playgame();
            //makes the myMovie obj and sets the Esrb Title and genre
            Movie myMovie = new Movie("PG", "Peak", "A Minecraft movie");
            //calls and writes the Describe methed using the myMovie obj to the console
            Console.WriteLine(myMovie.Describe());
            //calls the PlayMovie method
            myMovie.PlayMovie();
        }
    }
}
