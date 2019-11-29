using WarField.Common.Bullets;
using WarField.Common.Enumerates;

namespace WarField.Common.Weapons
{
    public interface IWeapon
    {
        IBullet Bullet { get; set; }
        AttackTargetAt TargetAt { get; set; }
        
        void Fire();
    }
}