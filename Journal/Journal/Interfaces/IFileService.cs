using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Interfaces
{
	public interface IFileService
	{
		void DeleteFile(string Path);
		void SaveFile(string Path, string Content);
		void SaveFile(string Path, Stream Content);
		string ReadFileAsString(string Path);
		Stream ReadFileAsStream(string Path);
	}
}
