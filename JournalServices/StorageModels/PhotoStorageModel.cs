using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalServices.StorageModels
{
	public class PhotoStorageModel
	{
		public string ImageName { get; set; }
		public string ImageLocation { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string LocationName { get; set; }
		public string ImageTitle { get; set; }
		public string ImageDescription { get; set; }
	}
}
