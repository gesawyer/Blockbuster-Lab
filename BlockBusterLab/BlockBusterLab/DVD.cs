using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD: Movie
    {
        public DVD(string Title, int RunTime, Genre Genre, List<string>Scenes):base(Title, RunTime, Genre, Scenes)
        {

        }
        public override void Play()
        {
            Console.WriteLine("Now playing:" + Title);
            Console.WriteLine("Hello there. What scene would you like to watch: 0 to " + (Scenes.Count - 1));
            foreach (string s in Scenes)
            {
                Console.WriteLine(s);
            }
            string choice= Console.ReadLine();
            int pick = int.Parse(choice);
            Console.WriteLine();
            Console.WriteLine($"Scene:{pick}");
            Console.WriteLine(Scenes[pick]);
        }
    }
}
