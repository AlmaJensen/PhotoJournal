using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalServices.Interfaces;
using System.IO;
using System.Diagnostics;
using Windows.Storage;


namespace Services.WinPhone.Services
{
	public class FileStorage : IFileService
	{

		public string MyDocumentsPath
		{
			get
			{
				return ApplicationData.Current.LocalFolder.Path; 
			}
		}

		public async void DeleteFile(string Path)
		{
			string fileName = ParseFileNameFromPath(Path);
			var datafolder = Windows.Storage.ApplicationData.Current.LocalFolder;
			var file  = await datafolder.GetFileAsync(fileName);
			await file.DeleteAsync(StorageDeleteOption.PermanentDelete);
		}

		public async Task<Stream> ReadFileAsStream(string Path)
		{
			string fileName = ParseFileNameFromPath(Path);
			var datafolder = Windows.Storage.ApplicationData.Current.LocalFolder;
			return await datafolder.OpenStreamForReadAsync(fileName);
		}

		public async Task<string> ReadFileAsString(string Path)
		{
			string fileName = ParseFileNameFromPath(Path);
			var datafolder = Windows.Storage.ApplicationData.Current.LocalFolder;
			using (var file = new StreamReader( await datafolder.OpenStreamForReadAsync(fileName)))
			{
				return await file.ReadToEndAsync();
			}
		}

		public async void SaveFile(string Path, Stream Content)
		{
			string fileName = ParseFileNameFromPath(Path);
			var datafolder = Windows.Storage.ApplicationData.Current.LocalFolder;
			var file = await datafolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
			using (var stream = await file.OpenStreamForWriteAsync())
			{
				var ms = new MemoryStream();
				Content.CopyTo(ms);
				var bytes = ms.ToArray();
				await stream.WriteAsync(bytes, 0, bytes.Length);
			}
		}

		public async void SaveFile(string Path, string Content)
		{
			var stringBytes = System.Text.Encoding.UTF8.GetBytes(Content.ToCharArray());
			string fileName = ParseFileNameFromPath(Path);
			var datafolder = Windows.Storage.ApplicationData.Current.LocalFolder;
			var file = await datafolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
			using (var stream = await file.OpenStreamForWriteAsync())
			{
				await stream.WriteAsync(stringBytes, 0, stringBytes.Length);
			}
		}

		private string ParseFileNameFromPath(string Path)
		{
			return Path.Replace(MyDocumentsPath, "");
		}
	}
}
