namespace Cake.ImageMagick
{
    public struct Displace
    {
        public RelativeInt HorizontalScale;
        public RelativeInt VerticalScale;
        public bool ArgumentsReferToDestinationImage;

        public Displace(RelativeInt horizontalScale, RelativeInt verticalScale = null, bool argumentsReferToDestinationImage = false)
        {
            HorizontalScale = horizontalScale;
            VerticalScale = verticalScale;
            ArgumentsReferToDestinationImage = argumentsReferToDestinationImage;
        }

        public override string ToString()
        {
            string result = HorizontalScale.ToString();
            if (VerticalScale != null)
            {
                result += $"x{VerticalScale}";
            }
            if (ArgumentsReferToDestinationImage)
            {
                result += "!";
            }
            return result;
        }
    }
}
