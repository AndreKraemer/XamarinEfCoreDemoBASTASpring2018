using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinEfCoreDemo.Models;

namespace XamarinEfCoreDemo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new XamarinEfCoreDemo.MainPage());
		}

		protected override void OnStart ()
		{
		    SQLitePCL.Batteries_V2.Init();
            // Handle when your app starts
            using (var db = new VegiContext())
		    {
                DbInitializer.Initialize(db);
		    }
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
