using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagement
{
	public class FilenameParts
	{
		public List<Filepart> FileParts { get; set; } = new List<Filepart>();

		public string Extension { get; set; }

		public override string ToString()
		{
			return string.Concat(string.Join("", FileParts.Select(part => part.Token)), ".", Extension);
		}
	}

	public struct Filepart
	{
		public string Token { get; set; }

		public bool IsOptional { get; set; }
	}
}
