using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.DataModels
{
	public class EntryModel
	{

		public DateTime DateOccurred { get; set; }
		public string EntryText { get; set; }
		public string EntryTitle { get; set; }
		public string EntrySummary { get; set; }
		public PhotoModel MainImage { get; set; }
		public List<PhotoModel> Images { get; set; }

	}
}
