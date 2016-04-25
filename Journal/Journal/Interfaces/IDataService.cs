using Journal.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Interfaces
{
	public interface IDataService
	{
		List<EntryModel> GetAllEntries();
		void CreateEntry(EntryModel entryModel);
		EntryModel ReadEntry(double entryID);
		void UpdateEntry(EntryModel entryModel);
		void DeleteEntry(double entryID);
	}
}
