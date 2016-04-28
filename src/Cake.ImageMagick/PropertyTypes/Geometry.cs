namespace Cake.ImageMagick
{
    public abstract class Geometry
    {
    }

    public enum DimensionMode
    {
        Maximum,
        Minimum,
        AspectRatioIgnore,
        Shrinks,
        Enlarges
    }
    public class Area: Geometry
    {
        public int Pixels;

        public Area(int pixels)
        {
            Pixels = pixels;
        }
    }

    public class Dimensions: Geometry
    {
        public DimensionMode Mode = DimensionMode.Maximum;
        public int? Width;
        public int? Height;

        public static Dimensions MaxWidth(int width)
        {
            return new Dimensions { Width = width };
        }

        public static Dimensions MaxHeight(int height)
        {
            return new Dimensions { Height = height };
        }

        private Dimensions()
        { }

        public Dimensions(int width, int height, DimensionMode mode)
        {
            Width = width;
            Height = height;
            Mode = mode;
        }
        public override string ToString()
        {
            string result = "";
            switch (Mode)
            {
                case DimensionMode.Maximum:
                    if (Width.HasValue)
                    {
                        result = Width.Value.ToString();
                    }
                    if (Height.HasValue)
                    {
                        result += $"x{Height.Value}";
                    }
                    break;
                default:
                    result = $"{Width.Value}x{Height.Value}";
                    switch (Mode)
                    {
                        case DimensionMode.Minimum:
                            result += "^";
                            break;
                        case DimensionMode.AspectRatioIgnore:
                            result += "!";
                            break;
                        case DimensionMode.Shrinks:
                            result += ">";
                            break;
                        case DimensionMode.Enlarges:
                            result += "<";
                            break;
                    }
                    break;
            }
            return result;
        }
    }

    public class Scale: Geometry
    {
        public int X;
        public int Y;

        public Scale(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Scale(int both)
        {
            X = Y = both;
        }

        public override string ToString()
        {
            if (X == Y)
            {
                return $"{X}%";
            }
            else
            {
                return $"{X}x{Y}%";
            }

        }
    }

    public class Offset
    {
        public int Width;
        public int Height;
        public int X;
        public int Y;

        public Offset(int width, int height, int x, int y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
        public Offset(int size, int x, int y)
        {
            Width = Height = size;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            string offset = (X == Y) ? X.ToString("+0;-0") : $"{X:+0;-0}{Y:+0;-0}";
            return $"{Width}x{Height}{offset}";
        }
    }
}
