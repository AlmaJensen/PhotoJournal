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
	public class MenuPageModel : FreshBasePageModel
	{
		public Command EntriesTapped
		{
			get
			{
				return new Command(async () => {
					await CoreMethods.PushPageModel<EntryListPageModel>();
				});
			}
		}
		public Command AccountsTapped
		{
			get
			{
				return new Command(async () => {
					await CoreMethods.PushPageModel<AccountPageModel>();
				});
			}
		}
		public Command SearchTapped
		{
			get
			{
				return new Command(async () => {
					await CoreMethods.PushPageModel<SearchPageModel>();
				});
			}
		}
		public Command MapTapped
		{
			get
			{
				return new Command(async () => {
					await CoreMethods.PushPageModel<MapPageModel>();
				});
			}
		}
		public Command LogoutTapped
		{
			get
			{
				return new Command(async () => {
					//await CoreMethods.PushPageModel<AccountPageModel>();
				});
			}
		}
	}
}
