namespace Awesify.ReallyGoodSongs
{
    class MegaManSelectionScreen : SuchAGoodSong
    {
        public override void WaitButListen()
        {
            var beeper = new Keyboard(140, Keyboard.Style.Swing);
            var keyboard = beeper.GetKeyboard();
            while (!shouldStop)
            {
                Beep(keyboard[50], beeper.qtriplet);
                Beep(keyboard[51], beeper.qtriplet);
                Beep(keyboard[53], beeper.qtriplet);

                Beep(keyboard[55], beeper.quarter);
                Beep(keyboard[55], beeper.quarter);
                Beep(keyboard[53], beeper.quarter);
                Beep(keyboard[53], beeper.quarter);

                Beep(keyboard[53], beeper.quarter);
                Beep(keyboard[53], beeper.eighth);
                Beep(keyboard[51], beeper.dquarter);
                Beep(keyboard[50], beeper.qtriplet);
                Beep(keyboard[51], beeper.qtriplet);
                Beep(keyboard[53], beeper.qtriplet);

                Beep(keyboard[55], beeper.quarter);
                Beep(keyboard[55], beeper.quarter);
                Beep(keyboard[53], beeper.quarter);
                Beep(keyboard[53], beeper.quarter);

                Beep(keyboard[53], beeper.quarter);
                Beep(keyboard[53], beeper.eighth);
                Beep(keyboard[52], beeper.dquarter);
            }
        }
    }
}
