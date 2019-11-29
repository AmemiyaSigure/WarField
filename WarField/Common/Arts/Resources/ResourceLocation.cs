using System;
using System.Collections.Generic;
using System.Text;

namespace WarField.Common.Arts.Resources
{
    public class ResourceLocation
    {
        private string Domain { get; }
        private string Path { get; }

        public ResourceLocation(string path)
        {
            Domain = "WarField";
            Path = path;
        }

        public ResourceLocation(string domain, string path)
        {
            Domain = domain;
            Path = path;
        }

        public override string ToString()
        {
            return Domain + ":" + Path;
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
