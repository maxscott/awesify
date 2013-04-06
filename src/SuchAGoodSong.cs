using System;
using System.Threading;
using System.Threading.Tasks;

namespace Awesify
{
    abstract class SuchAGoodSong
    {
        protected volatile bool shouldStop = false;

        protected void Beep(int x, int y)
        {
            if (shouldStop)
                Environment.Exit(0);
            Console.Beep(x, y);
        }

        protected void Sleep(int i)
        {
            if (shouldStop)
                Environment.Exit(0);
            Thread.Sleep(i);
        }

        public void Stop()
        {
            shouldStop = true;
        }

        public void KickOutTheJams()
        {
            shouldStop = false;
            new TaskFactory().StartNew(WaitButListen);
        }

        public void DotNetPerls()
        {
            for (int i = 37; i <= 32767; i += 200)
            {
                Beep(i, 100);
            }
        }

        public abstract void WaitButListen();
    }
}
