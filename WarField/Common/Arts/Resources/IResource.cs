using System;
using System.Collections.Generic;
using System.Text;
using WarField.Common.Enumerates;

namespace WarField.Common.Arts.Resources
{
    interface IResource
    {
        public string Name { get; set; }
        public ResourceType Type { get; set; }
        public ResourceLocation Location { get; set; }
    }
}
