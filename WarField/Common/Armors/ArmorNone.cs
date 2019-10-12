using System;
using System.Collections.Generic;
using System.Text;
using WarField.Common.Utilities.Enumerates;
using WarField.Common.Utilities.Interfaces;

namespace WarField.Common.Armors
{
    class ArmorNone : IArmor
    {
        public ArmorFor For { get; } = ArmorFor.Soldier;
        public double Armor { get; } = 0;
    }
}
