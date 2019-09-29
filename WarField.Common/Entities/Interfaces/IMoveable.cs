using WarField.Common.Results;
using WarField.Common.Utils.Maths;

namespace WarField.Common.Entities.Interfaces
{
    interface IMoveable
    {
        bool CanMove { get; set; }

        MoveResult Move(Vector3 target);
    }
}
