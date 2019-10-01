namespace WarField.Common.Utilities.Mathematics
{
    public abstract class EntityPosition : IBattlefieldPosition
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public int BlockX { get; set; }
        public int BlockY { get; set; }
        public int BlockZ { get; set; }
    }
}