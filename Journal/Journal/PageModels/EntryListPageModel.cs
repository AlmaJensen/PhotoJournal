using FreshMvvm;
using JournalServices.StorageModels;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.PageModels
{
    [ImplementPropertyChanged]
    public class EntryListPageModel : FreshBasePageModel
    {
		public ObservableCollection<EntryStorageModel> Entries { get; set; }
	}
}
