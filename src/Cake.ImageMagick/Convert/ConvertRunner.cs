using Cake.Core;
using Cake.Core.IO;
using System.Collections.Generic;

namespace Cake.ImageMagick
{
    public sealed class ConvertRunner: GenericImageMagickRunner<ImageMagickConvertSettings>
    {
        public ConvertRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IGlobber globber) 
            : base(fileSystem, environment, processRunner, globber)
        {}

        /// <summary>
        /// Gets the name of the tool.
        /// </summary>
        /// <returns>The name of the tool.</returns>
        protected override string GetToolName()
        {
            return "ImageMagickConvert";
        }

        /// <summary>
        /// Gets the possible names of the tool executable.
        /// </summary>
        /// <returns>The tool executable name.</returns>
        protected override IEnumerable<string> GetToolExecutableNames()
        {
            return new[] { "convert.exe", "convert" };
        }
    }
}
