using WarField.Common.Entities.Interfaces;
using WarField.Common.Entities.Soldiers.Base;
using WarField.Common.Results;

namespace WarField.Common.Entities.Soldiers
{
    class AlliedInfantry : Infantry, IDeployable
    {
        public bool HasDeployed { get; set; }

        public DeployResult Deploy()
        {
            HasDeployed = false;

            return DeployResult.Success;
        }
    }
}
