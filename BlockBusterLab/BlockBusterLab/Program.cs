using System;
using System.Linq;
using System.Collections.Generic;

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster b = new Blockbuster();
            b.PrintMovies();
            Console.WriteLine("Welcome to the last Blockbuster on earth. Here are all the movies we " +
               "have available. What movie would you like to rent today?");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            b.CheckOut(a);
            //b.PrintScenes();
        }
            
            
           
            
        

    }

}


        
       
    


   



  
    

