using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;
using System;

namespace Cake.ImageMagick
{
    partial class ImageMagickAliases
    {
        /// <summary>
        /// Converts an array of <paramref name="files"/> using default settings.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="files"></param>
        [CakeMethodAlias]
        [CakeAliasCategory("Drawing")]
        public static void ImageMagickConvert(this ICakeContext context, params FilePath[] files)
        {
            ImageMagickConvert(context, new ImageMagickConvertSettings(), files);
        }


        /// <summary>
        /// Converts an array of <paramref name="files"/> using the given <param name="settings"/>.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="files"></param>
        [CakeMethodAlias]
        [CakeAliasCategory("Drawing")]
		public static void ImageMagickConvert(this ICakeContext context, ImageMagickConvertSettings settings, params FilePath[] files)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (files == null || files.Length == 0)
            {
                throw new ArgumentNullException("containers");
            }
            var runner = new ConvertRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Globber);
            runner.Run(settings ?? new ImageMagickConvertSettings(), files);
        }
    }
}
