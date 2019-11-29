using WarField.Common.Weapons;

namespace WarField.Common.Interfaces
{
    public interface IAttackable
    {
        public IWeapon Weapon { get; set; }
    }
}