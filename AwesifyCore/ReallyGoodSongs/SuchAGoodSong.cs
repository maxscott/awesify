using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwesifyCore.ReallyGoodSongs
{
    public abstract class SuchAGoodSong
    {
        protected volatile bool ShouldStop = false;
        
        public void Stop()
        {
            ShouldStop = true;
        }

        /// <summary>
        /// Plays the song on a new thread, allowing you to Stop() at will.
        /// </summary>
        public void KickOutTheJams()
        {
            ShouldStop = false;
            new TaskFactory().StartNew(WaitButListen);
        }

        public void DotNetPerls()
        {
            for (int i = 37; i <= 32767; i += 200)
            {
                Console.Beep(i, 100);
            }
        }

        /// <summary>
        /// Plays the song on the same thread. This will block and you won't be able to call Stop().
        /// </summary>
        public abstract void WaitButListen();
    }
}
