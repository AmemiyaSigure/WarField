using WarField.Common.Arts.Animations;

namespace WarField.Common.Interfaces
{
    interface IDeployable
    {
        public bool CanDeployIn { get; set; }
        public bool Reversible { get; set; }
        public Animation AnimationDeploy { get; set; }
    }
}
