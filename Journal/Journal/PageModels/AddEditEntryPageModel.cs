using FreshMvvm;
using Journal.DataModels;
using Journal.Interfaces;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.PageModels
{
    [ImplementPropertyChanged]
    public class AddEditEntryPageModel : FreshBasePageModel
    {
		public EntryModel Entry { get; set; }
		IDataService _dataservice;
		public AddEditEntryPageModel(IDataService dataservice)
		{
			_dataservice = dataservice;
		}
		public override void Init(object initData)
		{
			Entry = initData as EntryModel;
			if (Entry == null)
				Entry = new EntryModel();
		}
	}
}
