﻿using System;
using Xamarin.Forms;
using App1.Views;
using Xamarin.Forms.Xaml;
using App1.Views.Master;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App1
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
          //  MainPage = new NavigationPage(new MasterDetailsPageDetail());
            MainPage = new MasterDetailsPage();
 
          //      MasterDetailsPageMaster();
            //MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
