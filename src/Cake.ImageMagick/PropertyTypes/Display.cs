namespace Cake.ImageMagick
{
    public struct Display
    {
        public string Host;
        public string TargetDisplay;
        public string Screen;

        public Display(string host, string display, string screen = null)
        {
            Host = host;
            TargetDisplay = display;
            Screen = screen;
        }

        public override string ToString()
        {
            string result = $"{Host}:{TargetDisplay}";
            if (!string.IsNullOrEmpty(Screen))
            {
                result += $".{Screen}";
            }
            return result;
        }

    }
}
