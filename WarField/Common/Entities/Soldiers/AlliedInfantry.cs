using WarField.Common.Arts.Animations;
using WarField.Common.Entities.Base;
using WarField.Common.Interfaces;

namespace WarField.Common.Entities.Soldiers
{
    public class AlliedInfantry : Infantry, IDeployable
    {
        public bool CanDeployIn { get; set; }
        public bool Reversible { get; set; }
        public Animation AnimationDeploy { get; set; }

        public AlliedInfantry()
        {
            
        }
    }
}