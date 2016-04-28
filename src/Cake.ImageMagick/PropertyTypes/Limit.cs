namespace Cake.ImageMagick
{
    public struct Limit
    {
        public LimitType Type;
        public string Value;

        public Limit(LimitType type, string value)
        {
            Type = type;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Type} {Value}";
        }
    }
}
