using System;
using AwesifyCore.Styles;

namespace AwesifyCore.ReallyGoodSongs
{
    public class MegaManSelectionScreen : SuchAGoodSong
    {
        public override void WaitButListen()
        {
            var beeper = new Keyboard(new Swing(140));
            var keyboard = beeper.GetKeyboard();
            while (!ShouldStop)
            {
                Console.Beep(keyboard[50], beeper.Qtriplet);
                Console.Beep(keyboard[51], beeper.Qtriplet);
                Console.Beep(keyboard[53], beeper.Qtriplet);

                if (ShouldStop) return;

                Console.Beep(keyboard[55], beeper.Quarter);
                Console.Beep(keyboard[55], beeper.Quarter);
                Console.Beep(keyboard[53], beeper.Quarter);
                Console.Beep(keyboard[53], beeper.Quarter);

                if (ShouldStop) return;

                Console.Beep(keyboard[53], beeper.Quarter);
                Console.Beep(keyboard[53], beeper.Eighth);
                Console.Beep(keyboard[51], beeper.Dquarter);
                Console.Beep(keyboard[50], beeper.Qtriplet);
                Console.Beep(keyboard[51], beeper.Qtriplet);
                Console.Beep(keyboard[53], beeper.Qtriplet);

                if (ShouldStop) return;

                Console.Beep(keyboard[55], beeper.Quarter);
                Console.Beep(keyboard[55], beeper.Quarter);
                Console.Beep(keyboard[53], beeper.Quarter);
                Console.Beep(keyboard[53], beeper.Quarter);

                if (ShouldStop) return;

                Console.Beep(keyboard[53], beeper.Quarter);
                Console.Beep(keyboard[53], beeper.Eighth);
                Console.Beep(keyboard[52], beeper.Dquarter);
            }
        }
    }
}
