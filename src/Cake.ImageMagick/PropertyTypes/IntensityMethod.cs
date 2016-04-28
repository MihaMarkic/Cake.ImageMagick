namespace Cake.ImageMagick
{
    public enum IntensityMethod
    {
        [ArgValue("Rec601Luma")]
        Rec601Luma,
        [ArgValue("Rec601Luminance")]
        Rec601Luminance,
        [ArgValue("Rec709Luma")]
        Rec709Luma,
        [ArgValue("Rec709Luminance")]
        Rec709Luminance,
        Brightness,
        Lightness,
        Average,
        [ArgValue("MS")]
        MS,
        [ArgValue("RMS")]
        RMS
    }
}
