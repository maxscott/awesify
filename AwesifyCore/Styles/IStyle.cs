namespace AwesifyCore.Styles
{
    public interface IStyle
    {
        int Bpm { get; }
        int Quarter { get; }
        int Half { get; }
        int Eighth { get; }
        int Sixteenth { get; }
        int Dquarter { get; }
        int Qtriplet { get; }
    }
}