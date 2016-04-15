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
		public List<EntryModel> GetAllEntries()
		{
			var entries = new List<EntryModel>();
			var entry1 = new EntryModel
			{
				EntryTitle = "Hello World1",
				EntrySummary = "Hello world1, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",
				EntryText = "Hello world11, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",

			};
			var entry2 = new EntryModel
			{
				EntryTitle = "Hello World22",
				EntrySummary = "Hello world22, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",
				EntryText = "Hello world22, this is just an example text blob to see what I can make of this entry.  I hope you enjoy reading my odd Lorem Ipsum dummy text.  It was probably just as fun to write as it was to read",
			};
			entries.Add(entry1);
			entries.Add(entry2);
			return entries;
		}
	}
}
