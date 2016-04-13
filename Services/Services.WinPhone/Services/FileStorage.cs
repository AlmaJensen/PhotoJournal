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
        public async Task<byte[]> ReadBytes(string path)
        {
            byte[] bytes = new byte[0];

            try
            {
                using (var fs = File.Open(path, FileMode.Open, FileAccess.Read)) // new FileStream(path, FileMode.Open))
                {
                    bytes = new byte[fs.Length];
                    await fs.ReadAsync(bytes, 0, (int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                //Insights.Report(ex, Insights.Severity.Error);
                throw;
            }
            return bytes;
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
                    Debug.WriteLine("Unable to delete: " + path);
                    return false;
                }
            });
        }

        public string MyDocumentsPath
        {
            get { return ApplicationData.Current.LocalFolder.Path; }
        }

        public Stream GetFileReadStream(string path)
        {
            try
            {
                return File.OpenRead(path);
            }
            catch (Exception ex)
            {
                Insights.Report(ex);
                return null;
            }

        }

        public long GetFileSize(string path)
        {
            var info = new FileInfo(path);
            return info.Length;
        }

        public async Task<bool> SaveStream(Stream stream, string path)
        {
            try
            {
                using (var fileStream = System.IO.File.OpenWrite(path))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(fileStream);
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }

        public async Task<bool> Save(string filePath, string stringToSave)
        {
			var stringBytes = System.Text.Encoding.UTF8.GetBytes( stringToSave.ToCharArray());
			var fileName = filePath.Replace(MyDocumentsPath, "");
			var datafolder = Windows.Storage.ApplicationData.Current.LocalFolder;
			var file = await datafolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
			using (var stream = await file.OpenStreamForWriteAsync())
			{
				await stream.WriteAsync(stringBytes, 0, stringBytes.Length);
				return true;
			}
        }

        Task<string> IFileService.GetFileReadStream(string path)
        {
            throw new NotImplementedException();
        }
    }
}
