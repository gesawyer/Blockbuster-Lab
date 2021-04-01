using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    public enum Genre
    {
        Comedy,
        Horror,
        Romance,
        Action,
        Drama,

    }
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }

        public Movie(string Title, int RunTime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
        }

        public override string ToString()
        {
            string output = "";
            output += $"Title: {Title}\n";
            output += $"RunTime: {RunTime} minutes \n";
            output += $"Genre: {Category}\n";
            return output;
        }

        public virtual string PrintInfo(int a)
        {
            string output = "";
            output += $"Title: {Title}\n";
            output += $"RunTime: {RunTime} minutes \n";
            output += $"Genre: {Category}\n";
            return output;
        }
        
        public void PrintScenes()
        {
            int num = 0;
            foreach (string s in Scenes)
            {
                Console.WriteLine($"{Scenes[num]}");
                Console.WriteLine(s);
            }
        }

        public abstract void Play(); 
    }
     
}