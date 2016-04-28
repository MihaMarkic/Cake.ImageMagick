namespace Cake.ImageMagick
{
    public struct RelativeInt
    {
        public bool IsPercentage;
        public int Value;

        public static RelativeInt FromAbsolute(int value)
        {
            return new RelativeInt { Value = value, IsPercentage = false };
        }

        public static RelativeInt FromRelative(int value)
        {
            return new RelativeInt { Value = value, IsPercentage = true };
        }

        public override string ToString()
        {
            string result = Value.ToString();
            if (IsPercentage)
            {
                result += "%";
            }
            return result;
        }
    }
}
