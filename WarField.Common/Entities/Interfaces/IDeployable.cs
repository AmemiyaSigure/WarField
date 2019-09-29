using WarField.Common.Results;

namespace WarField.Common.Entities.Interfaces
{
    interface IDeployable
    {
        bool HasDeployed { get; set; }

        DeployResult Deploy();
    }
}
