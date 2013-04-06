namespace Awesify.ReallyGoodSongs
{
    class ZeldaDeath : SuchAGoodSong
    {
        public override void WaitButListen()
        {
            var beeper = new Keyboard(160, Keyboard.Style.Swing);
            var keyboard = beeper.GetKeyboard();

            for (int i = 44; i > 40; i += 3)
            {
                Beep(keyboard[i--], beeper.sixteenth);
                Beep(keyboard[i--], beeper.sixteenth);
                Beep(keyboard[i--], beeper.sixteenth);
                Beep(keyboard[i--], beeper.sixteenth);
            }

            Beep(keyboard[37], beeper.half);

            for (int j = 37; j < 49; j++)
            {
                Beep(keyboard[j], 80);
            }

            Sleep(1000);

            while (!shouldStop)
            {
                Beep(keyboard[60], beeper.quarter); //fifth
                Beep(keyboard[48], beeper.quarter); //fifth
                Beep(keyboard[53], beeper.quarter); //root
                Beep(keyboard[57], beeper.quarter); //third

                Beep(keyboard[56], beeper.quarter); //-third
                Beep(keyboard[48], beeper.quarter); //fifth
                Beep(keyboard[64], beeper.quarter); //seventh
                Beep(keyboard[52], beeper.quarter); //seventh

                Beep(keyboard[62], beeper.quarter); //sixth
                Beep(keyboard[53], beeper.quarter); //root
                Beep(keyboard[57], beeper.quarter); //third
                Beep(keyboard[62], beeper.quarter); //sixth

                Beep(keyboard[60], beeper.quarter); //fifth
                Beep(keyboard[53], beeper.quarter); //root
                Beep(keyboard[55], beeper.quarter); //second
                Beep(keyboard[57], beeper.quarter); //third

                Beep(keyboard[62], beeper.quarter); //sixth
                Beep(keyboard[53], beeper.quarter); //root
                Beep(keyboard[58], beeper.quarter); //fourth
                Beep(keyboard[62], beeper.quarter); //sixth (3rd of 4)

                Beep(keyboard[61], beeper.quarter); //-sixth (-3rd of 4)
                Beep(keyboard[53], beeper.quarter); //root
                Beep(keyboard[55], beeper.quarter); //second
                Beep(keyboard[58], beeper.quarter); //fourth

                Beep(keyboard[57], beeper.quarter); //third
                Beep(keyboard[48], beeper.quarter); //fifth
                Beep(keyboard[53], beeper.quarter); //root
                Beep(keyboard[57], beeper.quarter); //third

                Beep(keyboard[55], beeper.quarter); //second
                Beep(keyboard[48], beeper.quarter); //fifth
                Beep(keyboard[50], beeper.quarter); //sixth
                Beep(keyboard[52], beeper.quarter); //seventh
            }
        }
    }
}
