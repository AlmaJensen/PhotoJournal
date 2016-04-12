using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalServices.StorageModels
{
	public class EntryStorageModel
	{
		public DateTime DateOccurred { get; set; }
		public string EntryText { get; set; }
		public string EntryTitle { get; set; }
		public PhotoStorageModel MainImage { get; set; }
		public List<PhotoStorageModel> Images { get; set; }
	}
}
