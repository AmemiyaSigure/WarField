using System;
using System.Collections.Generic;
using System.Text;
using WarField.Common.Arts.Animations;

namespace WarField.Common.Interfaces
{
    interface IDeathable
    {
        public long Health { get; set; }
        public Animation AnimationDeath { get; set; }
    }
}
