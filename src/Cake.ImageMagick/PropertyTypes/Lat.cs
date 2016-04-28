namespace Cake.ImageMagick
{
    public struct Lat
    {
        public int Width;
        public int Height;
        public RelativeInt Offset;

        public Lat(int width, int height, RelativeInt offset)
        {
            Width = width;
            Height = height;
            Offset = offset;
        }

        public override string ToString()
        {
            string sign = Offset.Value >= 0 ? "+" : "-";
            return $"{Width}x{Height}{sign}{Offset}";
        }
    }
}
