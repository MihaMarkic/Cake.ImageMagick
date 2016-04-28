namespace Cake.ImageMagick
{
    public struct MeanShift
    {
        public int Width;
        public int Height;
        public RelativeInt Distance;

        public MeanShift(int width, int height, RelativeInt distance = null)
        {
            Width = width;
            Height = height;
            Distance = distance;
        }

        public override string ToString()
        {
            string result = $"{Width}x{Height}";
            if (Distance != null)
            {
                result += $"+{Distance}";
            }
            return result;
        }
    }
}
