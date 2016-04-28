namespace Cake.ImageMagick
{
    public struct Copy
    {
        public Geometry Geometry;
        public Point Offset;

        public Copy(Geometry geometry, Point offset)
        {
            Geometry = geometry;
            Offset = offset;
        }

        public override string ToString()
        {
            return $"{Geometry} {Offset}";
        }
    }
}
