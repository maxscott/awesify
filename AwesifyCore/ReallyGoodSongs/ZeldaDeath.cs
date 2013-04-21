using System;
using System.Threading;
using AwesifyCore.Styles;

namespace AwesifyCore.ReallyGoodSongs
{
    public class ZeldaDeath : SuchAGoodSong
    {
        public override void WaitButListen()
        {
            var beeper = new Keyboard(new Straight(160));
            var keyboard = beeper.GetKeyboard();

            int i = 60;
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            i += 3;
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            i += 3;
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            i += 3;
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            Console.Beep(keyboard[i--], beeper.Sixteenth);
            

            Console.Beep(keyboard[53], beeper.Half);

            for (int j = 53; j < 70; j++)
            {
                Console.Beep(keyboard[j], beeper.Sixteenth);
            }

            Thread.Sleep(700);

            while (!ShouldStop)
            {
                Console.Beep(keyboard[60], beeper.Quarter); //fifth
                Console.Beep(keyboard[48], beeper.Quarter); //fifth
                Console.Beep(keyboard[53], beeper.Quarter); //root
                Console.Beep(keyboard[57], beeper.Quarter); //third

                Console.Beep(keyboard[56], beeper.Quarter); //-third
                Console.Beep(keyboard[48], beeper.Quarter); //fifth
                Console.Beep(keyboard[64], beeper.Quarter); //seventh
                Console.Beep(keyboard[52], beeper.Quarter); //seventh

                Console.Beep(keyboard[62], beeper.Quarter); //sixth
                Console.Beep(keyboard[53], beeper.Quarter); //root
                Console.Beep(keyboard[57], beeper.Quarter); //third
                Console.Beep(keyboard[62], beeper.Quarter); //sixth

                Console.Beep(keyboard[60], beeper.Quarter); //fifth
                Console.Beep(keyboard[53], beeper.Quarter); //root
                Console.Beep(keyboard[55], beeper.Quarter); //second
                Console.Beep(keyboard[57], beeper.Quarter); //third

                Console.Beep(keyboard[62], beeper.Quarter); //sixth
                Console.Beep(keyboard[53], beeper.Quarter); //root
                Console.Beep(keyboard[58], beeper.Quarter); //fourth
                Console.Beep(keyboard[62], beeper.Quarter); //sixth (3rd of 4)

                Console.Beep(keyboard[61], beeper.Quarter); //-sixth (-3rd of 4)
                Console.Beep(keyboard[53], beeper.Quarter); //root
                Console.Beep(keyboard[55], beeper.Quarter); //second
                Console.Beep(keyboard[58], beeper.Quarter); //fourth

                Console.Beep(keyboard[57], beeper.Quarter); //third
                Console.Beep(keyboard[48], beeper.Quarter); //fifth
                Console.Beep(keyboard[53], beeper.Quarter); //root
                Console.Beep(keyboard[57], beeper.Quarter); //third

                Console.Beep(keyboard[55], beeper.Quarter); //second
                Console.Beep(keyboard[48], beeper.Quarter); //fifth
                Console.Beep(keyboard[50], beeper.Quarter); //sixth
                Console.Beep(keyboard[52], beeper.Quarter); //seventh
            }
        }
    }
}
