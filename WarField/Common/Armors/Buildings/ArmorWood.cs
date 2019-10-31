using WarField.Common.Enumerates;
using WarField.Common.Interfaces;

namespace WarField.Common.Armors.Buildings
{
    public class ArmorWood : IArmor
    {
        public string Name { get; }
        public ArmorFor For { get; }
        public double Armor { get; }

        public ArmorWood()
        {
            Name = "Wood";
            For = ArmorFor.Building;
            Armor = 100;
        }
    }
}