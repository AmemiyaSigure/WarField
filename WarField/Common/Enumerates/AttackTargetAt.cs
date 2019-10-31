using System;

namespace WarField.Common.Enumerates
{
    [Flags]
    public enum AttackTargetAt
    {
        Land = 1, 
        Air = 2, 
        Sea = 4, 
        Divide = 8, 
        Ground = 16, 
        LandG = Land | Ground,  
        AirG = Air | Ground, 
        SeaG = Sea | Ground, 
        DivideG = Divide | Ground, 
        Entity = Land | Air | Sea | Divide, 
        All = Entity | Ground
    }
}