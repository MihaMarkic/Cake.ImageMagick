using System;

namespace Cake.ImageMagick
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field)]
    public class ArgValueAttribute:Attribute
    {
        public string Value;

        public ArgValueAttribute(string value)
        {
            Value = value;
        }
    }
}
