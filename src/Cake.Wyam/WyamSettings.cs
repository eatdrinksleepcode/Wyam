﻿using System.Collections.Generic;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Wyam
{
    /// <summary>
    /// Contains settings used by <see cref="WyamRunner"/>.
    /// </summary>
    public sealed class WyamSettings : ToolSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether to enable watching of input folder for changes to files.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool Watch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable previewing of the generated content in built in web server.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool Preview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the port number to use for previewing.
        /// </summary>
        /// <remarks>Default is 5080</remarks>
        public int PreviewPort { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable forcing of using file extensions.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool PreviewForceExtensions { get; set; }

        /// <summary>
        /// The path to the root of the preview server, if not the output folder.
        /// </summary>
        public DirectoryPath PreviewRoot { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the input paths that should be used while running Wyam.
        /// </summary>
        public IEnumerable<DirectoryPath> InputPaths { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the output path that should be used while running Wyam.
        /// </summary>
        public DirectoryPath OutputPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the configuration file that should be used while running Wyam.
        /// </summary>
        public FilePath ConfigurationFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable updating of packages.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool UpdatePackages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to output the scripts at end of execution.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool OutputScripts { get; set; }

        /// <summary>
        /// Compile the configuration but do not execute.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool VerifyConfig { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to prevent cleaning of the output path on each execution if <c>true</c>.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool NoClean { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to turn off the caching mechanism on all modules if <c>true</c>.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool NoCache { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to run in verbose mode.
        /// </summary>
        /// <remarks>Default is false</remarks>
        public bool Verbose { get; set; }

        /// <summary>
        /// Gets or sets the global metadata.
        /// </summary>
        public IDictionary<string, string> GlobalMetadata { get; set; }

        /// <summary>
        /// Gets or sets the path to the Wyam log file.
        /// </summary>
        public FilePath LogFilePath { get; set; }

        /// <summary>
        /// Gets or sets the The folder (or config file) to use as the root.
        /// </summary>
        /// <remarks>Default is the current working directory</remarks>
        public DirectoryPath RootPath { get; set; }
    }
}