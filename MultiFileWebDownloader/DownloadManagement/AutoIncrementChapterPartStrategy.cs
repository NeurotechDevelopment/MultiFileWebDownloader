using System;

namespace DownloadManagement
{
	public class AutoIncrementChapterPartStrategy : FilenameVariatorStrategy
	{
		/// <summary>
		/// Filename may consist of several variable parts.
		/// Consider following filenames. They have 3 parts.
		/// 1.Chapter1.Part1.mp3
		/// 2.Chapter2.mp3
		/// 
		/// Let CurrentFilename  1.Chapter1.Part1.mp3
		/// VariateNextPart() -> 2.Chapter1.Part2.mp3
		/// VariateNextPart() -> 2.Chapter2.Part1.mp3
		/// VariateNextPart() -> 2.Chapter2.mp3
		/// VariateNextPart() -> Exception("No more parts left")
		/// </summary>
		public override string VariateNextPart()
		{
			if (string.IsNullOrWhiteSpace(CurrentFilename))
			{
				throw new ArgumentNullException("CurrentFilename");
			}


			throw new NotImplementedException();
		}
	}
}
