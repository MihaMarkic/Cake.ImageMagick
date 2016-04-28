namespace Cake.ImageMagick
{
    public struct Blur
    {
        private object value;

        public static Blur FromRadiusSigme(int radius, int? sigma)
        {
            return new Blur { value = new RadiusSigma { Radius = radius, Sigma = sigma } };
        }
        public static Blur FromArea(int width, int? height, int? angle)
        {
            return new Blur { value = new BlurArea {  Width = width, Height = height, Angle = angle } };
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    public class BlurArea
    {
        public int Width;
        public int? Height;
        public int? Angle;

        public override string ToString()
        {
            string result = Width.ToString();
            if (Height.HasValue)
            {
                result += $"x{Height.Value}";
            }
            if (Angle.HasValue)
            {
                result += $"+{Angle.Value}";
            }
            return result;
        }
    }
}
