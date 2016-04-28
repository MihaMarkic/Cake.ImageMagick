namespace Cake.ImageMagick
{
    public struct HoughLines
    {
        public int Width;
        public int Height;
        public int? Threshold;

        public HoughLines(int width, int height, int? threshold = null)
        {
            Width = width;
            Height = height;
            Threshold = threshold;
        }

        public override string ToString()
        {
            string result = $"{Width}x{Height}";
            if (Threshold.HasValue)
            {
                result += $"+{Threshold}";
            }
            return result;
        }
    }
}
