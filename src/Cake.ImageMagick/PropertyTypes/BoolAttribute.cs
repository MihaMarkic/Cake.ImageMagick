using System;

namespace Cake.ImageMagick
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BoolAttribute: Attribute
    {
        public Options Options { get; set; }
    }

    public enum Options
    {
        PlusMinus,
        Minus
    }
}
