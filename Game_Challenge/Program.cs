using System;
/*
    Project: Guessing Game 
    Name: Timothy Janssen #0002830945
    Contribution:
    Feature:
    Start & End dates:
    References:
    Links:
*/

namespace Game_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            game.Init();
            
            while(game.IsGamePlaying() == true)
            {

            }

            Console.WriteLine("Thanks for playing. Come back soon! Press any key to quit.");
            Console.ReadKey();
            Environment.Exit(0);
            
        }
    }
}
