namespace AwesifyCore.Styles
{
    public class Swing : IStyle
    {
        public Swing(int bpm)
        {
            Bpm = bpm;

            Quarter = 1000 * 60 / bpm;
            Half = Quarter * 2;
            Eighth = (int)1.08 * (Quarter / 2);
            Sixteenth = Eighth / 2;
            Dquarter = Quarter + Eighth;
            Qtriplet = (int)(.82 * Quarter / 3);
        }

        public int Bpm { get; private set; }
        public int Quarter { get; private set; }
        public int Half { get; private set; }
        public int Eighth { get; private set; }
        public int Sixteenth { get; private set; }
        public int Dquarter { get; private set; }
        public int Qtriplet { get; private set; }
    }
}