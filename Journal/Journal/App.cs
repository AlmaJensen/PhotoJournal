using FreshMvvm;
using Journal.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Journal
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			//var masterDetail = new FreshMasterDetailNavigationContainer();
			//var detail = FreshPageModelResolver.ResolvePageModel<PageModels.PinPageModel>();
			//masterDetail.Detail = new FreshNavigationContainer(detail);
			//var master = FreshPageModelResolver.ResolvePageModel<MenuPageModel>();
			//master.Title = "Hello World";
			//masterDetail.Master = master;

			var masterDetailNav = new FreshMasterDetailNavigationContainer();
			masterDetailNav.Init("Menu");
			masterDetailNav.AddPage<PinPageModel>("Contacts", null);
			masterDetailNav.AddPage<MenuPageModel>("Pages", null);
			MainPage = masterDetailNav;

			//var page = FreshPageModelResolver.ResolvePageModel<PageModels.PinPageModel>();
			//var basicNavContainer = new FreshNavigationContainer(page);
			//MainPage = basicNavContainer;
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
