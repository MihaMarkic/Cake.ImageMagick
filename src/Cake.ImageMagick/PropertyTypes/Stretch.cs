namespace Cake.ImageMagick
{
    public struct Stretch
    {
        public RelativeDecimal BlackPoint;
        public RelativeDecimal WhitePoint;

        public Stretch(RelativeDecimal blackPoint, RelativeDecimal whitePoint = null)
        {
            BlackPoint = blackPoint;
            WhitePoint = whitePoint;
        }

        public override string ToString()
        {
            string result = BlackPoint.ToString();
            if (WhitePoint != null)
            {
                result += $"x{WhitePoint}";
            }
            return result;
        }
    }
}
