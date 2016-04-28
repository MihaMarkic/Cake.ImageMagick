namespace Cake.ImageMagick
{
    public struct Canny
    {
        public int Radius;
        public int? Sigma;
        public int? LowerPercent;
        public int? UpperPercent;

        public static Canny FromRadius(int radius)
        {
            return new Canny { Radius = radius, Sigma = null, LowerPercent = null, UpperPercent = null };
        }

        public static Canny FromRadiusAndSigma(int radius, int sigma, int? lowerPercent, int? upperPercent)
        {
            return new Canny { Radius = radius, Sigma = sigma, LowerPercent = lowerPercent, UpperPercent = upperPercent };
        }

        public override string ToString()
        {
            string result = Radius.ToString();
            if (Sigma.HasValue)
            {
                result += $"x{Sigma.Value}";
            }
            if (LowerPercent.HasValue)
            {
                result += $"+{LowerPercent.Value}";
            }
            if(UpperPercent.HasValue)
            {
                result += $"+{UpperPercent.Value}";
            }
            return result;
        }
    }
}
