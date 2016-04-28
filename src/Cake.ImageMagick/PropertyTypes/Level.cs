namespace Cake.ImageMagick
{
    public struct Level
    {
        public RelativeInt BlackPoint;
        public RelativeInt WhitePoint;
        public decimal? Gamma;

        public Level(RelativeInt blackPoint, RelativeInt whitePoint, decimal? gamma = null)
        {
            BlackPoint = blackPoint;
            WhitePoint = whitePoint;
            Gamma = gamma;
        }

        public override string ToString()
        {
            string result = $"{BlackPoint}";
            if (WhitePoint != null)
            {
                result += $",{WhitePoint}";
            }
            if (Gamma.HasValue)
            {
                result += $",{Gamma}";
            }
            return result;
        }
    }
}
