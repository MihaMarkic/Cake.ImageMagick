namespace Cake.ImageMagick
{
    public struct Crop
    {
        public Geometry Geometry;
        public bool EqualyDivide;
        public bool SetAsViewport;

        public Crop(Geometry geometry, bool equalyDivide = false, bool setAsViewport = false)
        {
            Geometry = geometry;
            EqualyDivide = equalyDivide = false;
            SetAsViewport = setAsViewport = false;
        }

        public override string ToString()
        {
            string result = Geometry.ToString();
            if (EqualyDivide)
            {
                result += "@";
            }
            if (SetAsViewport)
            {
                result += "!";
            }
            return result;
        }
    }
}
