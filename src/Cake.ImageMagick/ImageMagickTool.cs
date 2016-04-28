using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.ImageMagick
{
    /// <summary>
    /// Base class for Convert tool.
    /// </summary>
    /// <typeparam name="TSettings">The settings type.</typeparam>
    public abstract class ConvertTool<TSettings>: Tool<TSettings>
        where TSettings: AutoToolSettings
    {
        protected readonly ICakeEnvironment environment;
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTo"/> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="globber">The globber.</param>
        protected ConvertTool(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IGlobber globber)
            : base(fileSystem, environment, processRunner, globber)
        {
            if (environment == null)
            {
                throw new ArgumentNullException("environment");
            }
            this.environment = environment;
        }
    }
}
