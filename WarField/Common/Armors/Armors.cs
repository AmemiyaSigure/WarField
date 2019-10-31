using WarField.Common.Armors.Buildings;
using WarField.Common.Interfaces;

namespace WarField.Common.Armors
{
    class Armors
    {
        public static IArmor None = new ArmorNone();

        public static IArmor Wood = new ArmorWood();
    }
}
