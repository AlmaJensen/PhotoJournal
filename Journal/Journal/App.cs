﻿using FreshMvvm;
using Journal.Interfaces;
using Journal.PageModels;
using Journal.Services;
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
			FreshIOC.Container.Register<IDataService, DataService>();
			// The root page of your application
			var masterDetail = new FreshMasterDetailNavigationContainer();
			var detail = FreshPageModelResolver.ResolvePageModel<PageModels.PinPageModel>();
			masterDetail.Detail = new FreshNavigationContainer(detail);
			var master = FreshPageModelResolver.ResolvePageModel<MenuPageModel>();
			master.Title = "Hello World";
			masterDetail.Master = master;
			MainPage = masterDetail;

			//var masterDetailNav = new FreshMasterDetailNavigationContainer();
			//masterDetailNav.Init("Menu");
			//masterDetailNav.AddPage<PinPageModel>("Contacts", null);
			//masterDetailNav.AddPage<MenuPageModel>("Pages", null);
			//MainPage = masterDetailNav;

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
