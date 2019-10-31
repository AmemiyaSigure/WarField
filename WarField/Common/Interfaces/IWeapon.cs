using WarField.Common.Enumerates;

namespace WarField.Common.Interfaces
{
    public interface IWeapon
    {
        IBullet Bullet { get; set; }
        AttackTargetAt TargetAt { get; set; }
        
        void Fire();
    }
}