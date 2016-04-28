namespace Cake.ImageMagick
{
    public struct Distort
    {
        public DistortMethod Method;
        public string Arguments;

        public Distort(DistortMethod method, string arguments)
        {
            Method = method;
            Arguments = arguments;
        }

        public override string ToString()
        {
            return $"{Method} {Arguments}";
        }
    }

    public enum DistortMethod
    {
        ScaleRotateTranslate,
        Affine,
        AffineProjection,
        BilinearForward,
        BilinearReverse,
        Perspective,
        PerspectiveProjection,
        Arc,
        Polar,
        DePolar,
        Barrel,
        BarrelInverse,
        Shepards
    }
}
