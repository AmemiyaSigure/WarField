using WarField.Common.Arts.Icons;

namespace WarField.Common.Interfaces
{
    interface IBuildable
    {
        public bool CanBuild { get; set; }
        public int Cost { get; set; }
        public Icon Icon { get; set; }
    }
}
