using WarField.Common.Utilities.Enumerates;
using WarField.Common.Utilities.Interfaces;

namespace WarField.Common.Armors.Buildings
{
    public class ArmorWood : IArmor
    {
        public string Name { get; }
        public ArmorFor For { get; }

        public ArmorWood()
        {
            Name = "Wood";
            For = ArmorFor.Building;
        }
    }
}