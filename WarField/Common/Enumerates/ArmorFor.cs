using System;

namespace WarField.Common.Enumerates
{
    [Flags]
    public enum ArmorFor
    {
        Building = 1, 
        Soldier = 2, 
        Vehicles = 4, 
        All = Building + Soldier + Vehicles
    }
}