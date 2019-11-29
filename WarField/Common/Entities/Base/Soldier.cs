using WarField.Common.Armors.Soldiers;
using WarField.Common.Arts.Animations;
using WarField.Common.Arts.Icons;
using WarField.Common.Interfaces;
using WarField.Common.Utilities.Mathematics;
using WarField.Common.Weapons;

namespace WarField.Common.Entities.Base
{
    public class Soldier : Entity, IBuildable, IAttackable, IDeathable
    {
        public new IArmorSoldier Armor { get; set; }

        public new SoldierPosition Position { get; set; }
        public bool IsCreeping { get; set; }

        public bool CanBuild { get; set; }
        public int Cost { get; set; }
        public Icon Icon { get; set; }

        public IWeapon Weapon { get; set; }

        public Animation AnimationDeath { get; set; }
    }
}