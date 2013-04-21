using System.Linq;
using AwesifyCore.Styles;

namespace AwesifyCore
{
    public class Keyboard
    {
        public int Bpm = 120;
        public int Quarter;
        public int Half;
        public int Eighth;
        public int Sixteenth;
        public int Dquarter;
        public int Qtriplet;
        
        public Keyboard(IStyle style)
        {
            Bpm = style.Bpm;
            Quarter = style.Quarter;
            Half = style.Half;
            Eighth = style.Eighth;
            Sixteenth = style.Sixteenth;
            Dquarter = style.Dquarter;
            Qtriplet = style.Qtriplet;
        }

        public int[] GetKeyboard()
        {
            var v2 = typeof (Notes)
                .GetFields()
                .Select(pi => pi.GetValue(new Notes()))
                .Cast<double>()
                .Select(d => (int) d)
                .OrderBy(d => d)
                .ToArray();
            return v2;
        }
    }
}
