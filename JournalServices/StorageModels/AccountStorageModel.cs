using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalServices.StorageModels
{
	public class AccountStorageModel
	{
		public string Email { get; set; }
		public string Pin { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public List<EntryStorageModel> Entries { get; set; }
	}
}
