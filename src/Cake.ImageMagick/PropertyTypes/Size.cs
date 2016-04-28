namespace Cake.ImageMagick
{
    public struct AreaSize
    {
        public int Width;
        public int? Height;

        public AreaSize(int width, int? height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            string result = Width.ToString();
            if (Height.HasValue)
            {
                return $"x{Height.Value}";
            }
            return result;
        }
    }
}
