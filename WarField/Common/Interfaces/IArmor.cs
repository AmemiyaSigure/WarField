using WarField.Common.Enumerates;

namespace WarField.Common.Interfaces
{
    public interface IArmor
    {
        string Name { get; }
        ArmorFor For { get; }
        double Armor { get; }
    }
}