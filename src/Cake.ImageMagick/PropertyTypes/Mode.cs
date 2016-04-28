namespace Cake.ImageMagick
{
    public struct Mode
    {
        public readonly object Value;

        public Mode(Geometry geometry)
        {
            Value = geometry;
        }

        public Mode(ModeType type)
        {
            Value = type;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
