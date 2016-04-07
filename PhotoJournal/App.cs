using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;

using Xamarin.Forms;

namespace PhotoJournal
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			//MainPage = new NavigationPage(new Pages.RegistrationPage());
			var page = FreshPageModelResolver.ResolvePageModel<PageModels.RegistrationPageModel>();
			var basicNavContainer = new FreshNavigationContainer(page);
			MainPage = basicNavContainer;
		}



		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
