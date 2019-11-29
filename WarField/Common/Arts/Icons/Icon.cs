using System.Drawing;
using WarField.Common.Arts.Resources;
using WarField.Common.Enumerates;

namespace WarField.Common.Arts.Icons
{
    public class Icon : IResource
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public ResourceLocation Location { get; set; }
        public ResourceType Type { get; set; }
    }
}
