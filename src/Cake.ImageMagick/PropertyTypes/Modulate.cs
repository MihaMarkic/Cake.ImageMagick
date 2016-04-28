namespace Cake.ImageMagick
{
    public class Modulate
    {
        public int Brightness;
        public int? Saturation;
        public int? Hue;

        public Modulate(int brightness, int? saturation = null, int? hue = null)
        {
            Brightness = brightness;
            Saturation = saturation;
            Hue = hue;
        }

        public override string ToString()
        {
            return $"{Brightness},{Saturation},{Hue}";
        }
    }
}
