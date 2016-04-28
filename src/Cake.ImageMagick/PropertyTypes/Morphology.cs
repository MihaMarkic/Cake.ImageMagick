namespace Cake.ImageMagick
{
    public struct Morphology
    {
        public string Method;
        public string Kernel;

        public Morphology(string method, string kernel)
        {
            Method = method;
            Kernel = kernel;
        }

        public override string ToString()
        {
            return $"{Method} {Kernel}";
        }
    }
}
