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
	public class RegistrationPageModel : FreshBasePageModel
	{
		public string NamePlaceHolder { get; set; } = "Name";
		public string NameText { get; set; }
		public string NameError { get; set; } = "Name is required";
		public bool NameErrorVisible { get; set; } = false;
		public string EmailPlaceHolder { get; set; } = "Name";
		public string EmailText { get; set; }
		public string EmailError { get; set; } = "Name is required";
		public bool EmailErrorVisible { get; set; } = false;
		public string PasswordPlaceHolder { get; set; } = "Password";
		public string PasswordText { get; set; }
		public string PasswordError { get; set; } = "Password is required";
		public bool PasswordErrorVisible { get; set; }
		public string PinPlaceHolder { get; set; } = "4 digit pin";
		public string PinText { get; set; }
		public string PinError { get; set; } = "Pin is required";
		public bool PinErrorVisible { get; set; } = false;
		public string RegisterText { get; set; } = "Register";
		public Command MyProperty
		{
			get
			{
				return new Command(async x => await CoreMethods.PushPageModel<RegistrationPageModel>());
			}
		}
	}
}
