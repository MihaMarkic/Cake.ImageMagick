namespace Cake.ImageMagick
{
    public struct RadiusSigma
    {
        public int Radius;
        public int? Sigma;

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
