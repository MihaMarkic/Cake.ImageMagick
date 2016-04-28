namespace Cake.ImageMagick
{
    public enum InterlaceType
    {
        none,
        line,
        plane,
        partition,
        [ArgValue("JPEG")]
        JPEG,
        [ArgValue("GIF")]
        GIF,
        [ArgValue("PNG")]
        PNG,
    }
}
