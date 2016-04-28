namespace Cake.ImageMagick
{
    public struct LevelColors
    {
        public string BlackColor;
        public string WhiteColor;

        public LevelColors(string blackColor, string whiteColor)
        {
            BlackColor = blackColor;
            WhiteColor = whiteColor;
        }

        public override string ToString()
        {
            string result = "";
            if (BlackColor != null)
            {
                result = BlackColor;
            }
            if (!string.IsNullOrEmpty(WhiteColor))
            {
                result += "," + WhiteColor;
            }
            return result;
        }
    }
}
