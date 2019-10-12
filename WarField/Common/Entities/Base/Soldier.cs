using WarField.Common.Bases;
using WarField.Common.Utilities.Interfaces;
using WarField.Common.Utilities.Mathematics;

namespace WarField.Common.Entities.Base
{
    public class Soldier : Entity, IAttackable
    {
        public new SoldierPosition Position { get; set; }
        
        
    }
}