using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS: Movie
    {
        public VHS(string Title, int RunTime, Genre Genre, List<string> Scenes) : base(Title, RunTime, Genre, Scenes)
        {

        }
        public int CurrentTime { get; set; }
        public static void Rewind()
        {
            int CurrentTime = 0;
        }
        
        public override void Play()
        {
            if (CurrentTime >= 0 && CurrentTime <= 20)
            {
                Console.WriteLine(Scenes[1]);
                CurrentTime += 20;

            }
            if (CurrentTime >= 21 && CurrentTime <= 40)
            {
                Console.WriteLine(Scenes[2]);
                CurrentTime += 20;
            }
            if (CurrentTime >= 41 && CurrentTime <= 60)
            {
                Console.WriteLine(Scenes[3]);
                CurrentTime += 20;
            }
            if (CurrentTime >= 61 && CurrentTime <= 80)
            {
                Console.WriteLine(Scenes[4]);
                CurrentTime += 20;
            }
            else
            {
                Console.WriteLine(Scenes[5]);
                CurrentTime += 20;
            }

        }
    }
    
}
