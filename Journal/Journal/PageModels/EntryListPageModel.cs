using FreshMvvm;
using Journal.DataModels;
using Journal.Interfaces;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Journal.PageModels
{
    [ImplementPropertyChanged]
    public class EntryListPageModel : FreshBasePageModel
    {
		IDataService _dataService;
		public EntryListPageModel(IDataService dataService)
		{
			_dataService = dataService;
		}

		public override void Init(object initData)
		{
			Entries = new ObservableCollection<EntryModel>(_dataService.GetAllEntries());
		}
		public ObservableCollection<EntryModel> Entries { get; set; }

		EntryModel _selectedEntry;

		public EntryModel SelectedEntry
		{
			get
			{
				return _selectedEntry;
			}
			set
			{
				_selectedEntry = value;
				if (value != null)
					EntrySelected.Execute(value);
			}
		}

		public Command<EntryModel> EntrySelected
		{
			get
			{
				return new Command<EntryModel>(async (entry) => {
					await CoreMethods.PushPageModel<EntryMainPageModel>(entry);
				});
			}
		}
	}
}
