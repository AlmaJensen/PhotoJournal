using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalServices.Interfaces
{
	public interface IFileService
	{
		string MyDocumentsPath { get; }
		Task<bool> Delete(string path);
		Task<bool> Save(string filePath, string stringToSave);
		Task<string> GetFileReadStream(string path);
	}
}
