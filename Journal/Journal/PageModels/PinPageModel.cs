using FreshMvvm;
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
	class PinPageModel : FreshBasePageModel
	{
		public string EntryText {
			get;
			set;
		}
		public Command LoginCommand {
			get
			{
				return new Command(async x => await CoreMethods.PushPageModel<PinPageModel>());
			}
		}

	}
}
