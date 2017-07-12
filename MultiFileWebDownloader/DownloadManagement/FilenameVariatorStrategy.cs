using System.Collections.Generic;

namespace DownloadManagement
{
	public abstract class FilenameVariatorStrategy
	{
		/// <summary>
		/// Gets or sets format of a file.
		/// <example>
		/// {0:3} Chapter{1}.Part{2}.mp3
		/// </example>
		/// </summary>
		public string FilenameFormat { get; set; }

		/// <summary>
		/// Gets or sets variable parts of <see cref="FilenameFormat"/>.
		/// <example>
		/// { "{0:3} " , "Chapter{1}", ".Part{2}" } 
		/// </example>
		/// </summary>
		public FilenameParts Parts { get; set; }

		/// <summary>
		/// Gets or sets current filename.
		/// </summary>
		public string CurrentFilename { get; protected set; }

		/// <summary>
		/// Variates parts of a file according to rule defined in a derived class.
		/// </summary>
		public abstract string VariateNextPart();
	}
}
