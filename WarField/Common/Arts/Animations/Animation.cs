using System.Drawing;
using WarField.Common.Arts.Resources;
using WarField.Common.Enumerates;

namespace WarField.Common.Arts.Animations
{
    public class Animation : IResource
    {
        public string Name { get; set; }
        public Image[] Images { get; set; }
        public ResourceLocation Location { get; set; }
        public ResourceType Type { get; set; }
    }
}
