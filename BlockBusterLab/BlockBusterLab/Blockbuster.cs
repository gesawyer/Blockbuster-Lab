using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BlockBusterLab
{
    class Blockbuster
       
    {
        public List<Movie> Movies { get; set; }
        public Blockbuster()
        {
            Movies = new List<Movie>();

            Movie m = new DVD("The Place Beyond the Pines", 120, Genre.Drama, new List<string>()
            { "Robbing a bank", "Ryan Gosling is blonde now", "Ryan jumps out a window", "A cop gets shot", "Ryan cuts down a pine tree" }); ;
            Movie m1 = new DVD("Uncut Gems", 90, Genre.Action, new List<string>()
            { "Doing business in a jewelry store", "Hanging with a sidepiece", "Betting lots of money", "RIP main character","Sidepiece is rich" });
            Movie m2 = new DVD("Zoolander", 100, Genre.Comedy, new List<string>() { "Freak gasoline fight", "But why male models", "A scene for ants", "Derelicte" });
            Movie m3 = new VHS("Burn After Reading", 150, Genre.Comedy, new List<string>()
            {"Drunk FBI man is drunk", "Everyone cheats on their spouse", "Half the cast gets shot", "The Russian Embassy,", "Frances gets her plastic surgery money" });
            Movie m4 = new VHS("The Princess Bride", 110, Genre.Romance, new List<string>() { "As you wish", "Rodents of unusual size", "Mostly dead/ slightly alive", "Mawwiage" });
            Movie m5 = new VHS("The Ritual", 98, Genre.Horror, new List<string>() { "Killed in a convenience store", "Let's go camping", "Yikes what're all those symbols", "Human sacrifice", "the Jötunn" });
            Movies.Add(m);
            Movies.Add(m1);
            Movies.Add(m2);
            Movies.Add(m3);
            Movies.Add(m4);
            Movies.Add(m5);
            Scenes = new List<String>();
        }
        public void PrintMovies()
        {
            foreach (Movie m in Movies)
            {
                Console.WriteLine(Movies.IndexOf(m)+1);
                Console.WriteLine(m.Title);
                //Console.WriteLine(m);
            }
        }

        //public void PrintInfo(int num)
        //{
        //   foreach (Movie m in Movies)
        //    {
        //        string output = "";
        //        output += $"{Title}";
        //        Console.WriteLine(Movies.IndexOf(m));
        //        Console.WriteLine(num);
        //        Console.WriteLine(output);
        //    }
        //}

        public virtual string PrintInfo(int a)
        {
            string output = "";
            output += $"Title: {Title}\n";
            output += $"RunTime: {RunTime} minutes \n";
            output += $"Genre: {Category}\n";
            return output;
        }
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public void Movie(string Title, int RunTime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
            
        }
        public List<string> Scenes { get; set; }

        //public virtual string PrintInfo(int a)
        //{
        //    string output = "";
        //    output += $"Title: {Title}\n";
        //    //output += $"RunTime: {RunTime} minutes \n";
        //    //output += $"Genre: {Category}\n";
        //    return output;
        //}
        public void PrintScenes(int a)
        {
            foreach (string s in Scenes)
            {
                Console.WriteLine(Scenes.IndexOf(s));
                Console.WriteLine(s);
                return ;
            }
        }

        public Movie GetMovie(int num)
        {
            return Movies[num];
        }

        public void CheckOut()// Print movies// Get the index // Print info// return Movie
        {
            //PrintMovies();
            //Console.WriteLine("Please enter a number 0-5 for the movie you would like to see.");
            
            int num = int.Parse(Console.ReadLine());
            Movie m = GetMovie(num - 1);
            m.PrintInfo(num);
            //Console.WriteLine($"{ Scenes[num]}");

            
            
        }
    }
    
    
}
