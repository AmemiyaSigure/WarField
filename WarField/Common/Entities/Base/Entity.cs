using WarField.Common.Interfaces;
using WarField.Common.Utilities.Mathematics;

namespace WarField.Common.Entities.Base
{
    public class Entity
    {
        public long Health { get; set; }
        public IArmor Armor { get; set; }
        public double Speed { get; set; }

        public EntityPosition Position { get; set; }
        public int Vision { get; set; }
    }
}
