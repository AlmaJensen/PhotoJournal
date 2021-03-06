﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalServices.Interfaces
{
	public interface IFileService
	{
		string MyDocumentsPath { get; }
		void DeleteFile(string Path);
		void SaveFile(string Path, string Content);
		void SaveFile(string Path, Stream Content);
		Task<string> ReadFileAsString(string Path);
		Task<Stream> ReadFileAsStream(string Path);
	}
}
