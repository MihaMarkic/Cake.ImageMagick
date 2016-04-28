namespace Cake.ImageMagick
{
    public struct BrightnessContrast
    {
        public int Brightness;
        public int? Contrast;
        public bool IsPercentage;

        public BrightnessContrast(int brightness, int? contrast = null, bool isPercentage = false)
        {
            Brightness = brightness;
            Contrast = contrast;
            IsPercentage = isPercentage;
        }

        public override string ToString()
        {
            string result = Brightness.ToString();
            if (Contrast.HasValue)
            {
                result += $"x{Contrast.Value}";
            }
            if (IsPercentage)
            {
                result += "%";
            }
            return result;
        }
    }
}
