using WarField.Common.Entities.Interfaces;
using WarField.Common.Results;
using WarField.Common.Utils.Maths;

namespace WarField.Common.Entities.Soldiers.Base
{
    public class Infantry : IMoveable
    {
        public bool CanMove { get; set; }

        public MoveResult Move(Vector3 target)
        {
            return MoveResult.Failed;
        }
    }
}