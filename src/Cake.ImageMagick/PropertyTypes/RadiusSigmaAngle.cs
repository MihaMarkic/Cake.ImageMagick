namespace Cake.ImageMagick
{

    public struct RadiusSigmaAngle
    {
        public int Radius;
        public int? Sigma;
        public int? Angle;
        public RadiusSigmaAngle(int radius)
        {
            Radius = radius;
            Sigma = null;
            Angle = null;
        }
        public RadiusSigmaAngle(int radius, int sigma, int angle)
        {
            Radius = radius;
            Sigma = sigma;
            Angle = angle;
        }

        public override string ToString()
        {
            string result = Radius.ToString();
            if (Sigma.HasValue)
            {
                result += $"x{Sigma.Value}";
            }
            return result;
        }
    }
}
