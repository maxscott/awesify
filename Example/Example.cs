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
            Console.WriteLine("Press any key to kill the music.");
            Console.ReadKey();
            whatever.Stop();
            Console.WriteLine("YAY, You ended the music! Press again to start a new song.");
            Console.ReadKey();
            whatever = new MegaManSelectionScreen();
            whatever.KickOutTheJams();
        }
    }
}
