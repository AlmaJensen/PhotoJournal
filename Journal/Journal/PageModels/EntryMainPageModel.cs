using FreshMvvm;
using Journal.DataModels;
using Journal.Interfaces;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Journal.PageModels
{
    [ImplementPropertyChanged]
    public class EntryMainPageModel : FreshBasePageModel
    {
		public EntryModel Entry { get; set; }
		IDataService _dataservice;
		public EntryMainPageModel(IDataService dataservice)
		{
			_dataservice = dataservice;
		}

		public override void Init(object initData)
		{
			Entry = initData as EntryModel;
			if (Entry == null)
				Entry = new EntryModel();
		}
		public Command EditClicked
		{
			get
			{
				return new Command(async () =>
				{
					await CoreMethods.PushPageModel<AddEditEntryPageModel>(Entry);
				});
			}
		}
	}
}
