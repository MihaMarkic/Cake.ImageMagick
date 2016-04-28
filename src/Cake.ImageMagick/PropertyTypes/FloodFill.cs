namespace Cake.ImageMagick
{
    public struct FloodFill
    {
        public int X;
        public int Y;
        public string Color;

        public FloodFill(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public override string ToString()
        {
            return $"{X:+0;-0}{X:+0;-0} {Color}";
        }
    }
}
