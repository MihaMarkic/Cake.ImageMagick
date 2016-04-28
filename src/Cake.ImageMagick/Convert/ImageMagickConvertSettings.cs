namespace Cake.ImageMagick
{
    /// <summary>
    /// Settings for ImageMagick convert
    /// </summary>
    public sealed class ImageMagickConvertSettings: AutoToolSettings
    {
        /// <summary>
        /// Force the removal of a running container (uses SIGKILL)
        /// </summary>
        public bool Force { get; set; }
        /// <summary>
        /// Remove the specified link
        /// </summary>
        public bool Link { get; set; }
        /// <summary>
        /// Remove the volumes associated with the container
        /// </summary>
        public bool Volumes { get; set; }
    }
}
