using System;
using AwesifyCore.ReallyGoodSongs;

namespace Example
{
    class Example
    {
        public static void Main()
        {
            SuchAGoodSong whatever = new ZeldaDeath();
            whatever.KickOutTheJams();

            Console.WriteLine("You died!");
            Console.ReadKey();
            
            whatever.Stop();
            
            Console.WriteLine("Exiting...");
        }
    }
}
