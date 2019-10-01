using WarField.Common.Utilities.Enumerates;

namespace WarField.Common.Utilities.Interfaces
{
    public interface IWeapon
    {
        IBullet Bullet { get; set; }
        AttackTargetAt TargetAt { get; set; }
        
        void Fire();
    }
}