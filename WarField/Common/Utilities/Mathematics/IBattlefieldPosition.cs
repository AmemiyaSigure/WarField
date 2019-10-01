namespace WarField.Common.Utilities.Mathematics
{
    public interface IBattlefieldPosition : IPosition
    {
        int BlockX { get; set; }
        int BlockY { get; set; }
        int BlockZ { get; set; }
    }
}