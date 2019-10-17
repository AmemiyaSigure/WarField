using WarField.Common.Utilities.Enumerates;

namespace WarField.Common.Utilities.Interfaces
{
    public interface IArmor
    {
        string Name { get; }
        ArmorFor For { get; }
    }
}