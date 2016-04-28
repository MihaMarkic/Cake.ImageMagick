using Cake.Core;
using Cake.Core.IO;
using System;

namespace Cake.ImageMagick
{
    public abstract class GenericImageMagickRunner<TSettings> : ConvertTool<TSettings>
        where TSettings: AutoToolSettings, new()
    {
        public GenericImageMagickRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IGlobber globber) 
            : base(fileSystem, environment, processRunner, globber)
        {
        }

        public void Run(TSettings settings, FilePath[] files)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            if (files == null || files.Length == 0)
            {
                throw new ArgumentNullException("files");
            }
            Run(settings, GetArguments(settings, files));
        }

        private ProcessArgumentBuilder GetArguments(TSettings settings, FilePath[] files)
        {
            var builder = new ProcessArgumentBuilder();
            builder.AppendAll(environment, settings, files);
            return builder;
        }
    }
}
