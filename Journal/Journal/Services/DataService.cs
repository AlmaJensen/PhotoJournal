using Journal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journal.DataModels;

namespace Journal.Services
{
	public class DataService : IDataService
	{
		private List<EntryModel> _entries;
		public DataService()
		{
			_entries = new List<EntryModel>
			{
				new EntryModel
			{
				
				EntryTitle = "Hello World1",
				EntrySummary = "Hello world1, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",
				EntryText = "Hello world11, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",

			},
				new EntryModel
			{
				EntryTitle = "Hello World22",
				EntrySummary = "Hello world22, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",
				EntryText = "Hello world22, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",
			}
		};
		}
		public void CreateEntry(EntryModel entryModel)
		{
			if (entryModel != null)
				_entries.Add(entryModel);
		}

		public void DeleteEntry(double entryID)
		{
			var entry = ReadEntry(entryID);
			_entries.Remove(entry);
		}

		public List<EntryModel> GetAllEntries()
		{
			return _entries;
		}

		public EntryModel ReadEntry(string entryID)
		{
			throw new NotImplementedException();
		}

		public EntryModel ReadEntry(double entryID)
		{
			return _entries.Find(x => x.EntryID == entryID);
		}

		public void UpdateEntry(EntryModel entryModel)
		{
			var entry = _entries.Find(x => x.EntryID == entryModel.EntryID);
			entry = entryModel;
		}
	}
}
