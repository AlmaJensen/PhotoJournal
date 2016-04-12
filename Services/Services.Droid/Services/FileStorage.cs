using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using JournalServices.Interfaces;
using System.Threading.Tasks;
using System.IO;


namespace Services.Droid.Services
{
	public class FileStorage : IFileService
	{
		public string MyDocumentsPath { get { return System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); } }
		public async Task<string> GetFileReadStream(string path)
		{
			try
			{
				using (var stream = File.OpenRead(path))
				{
					using (var sr = new StreamReader(stream))
						return sr.ReadToEnd();
				}
			}
			catch
			{
				return null;
			}

		}
		public async Task<bool> Delete(string path)
		{
			return await Task.Run(() =>
			{
				try
				{
					System.IO.File.Delete(path);
					return true;
				}
				catch
				{
					return false;
				}
			});
		}
		public async Task<bool> Save(string filePath, string stringToSave)
		{
			try
			{
				return await SaveString(filePath, stringToSave);
			}
			catch
			{
				return false;
			}

		}

		private static async Task<bool> SaveString(string filePath, string stringToSave)
		{
			var stringBytes = Encoding.UTF8.GetBytes(stringToSave);
			using (var sr = new MemoryStream(stringBytes))
			{
				var fileStream = File.OpenWrite(filePath);
				sr.Seek(0, SeekOrigin.Begin);
				sr.CopyTo(fileStream);
				return true;
			}
		}
	}
}