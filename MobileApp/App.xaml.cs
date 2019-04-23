using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp {
	public partial class App : Application {

		public App ()
		{
            String MyLicense = "OTA1NDZAMzEzNzJlMzEyZTMwWnhyMHpsdWRDdmtybFIzcjFEd2dhcitDNHlvamdZUDRsdU10QmtTOXo5RT0=;OTA1NDdAMzEzNzJlMzEyZTMwQWtmcno1ZTRoaDhLMG5JRXhERlcwSWlSQmFBc3lscTVjVytQVkI5c1l0bz0=;OTA1NDhAMzEzNzJlMzEyZTMwSnpPcG5BbUhzRWdNWGpxcDZMS1VvMlZDSm9HOHZaY0cvV3F2ZkhkUjlUMD0=;OTA1NDlAMzEzNzJlMzEyZTMwU0VJekJzWXNIYzM0bDVGMXhWZXRXVVR5OG5tOVl1cTd5YmN1Uk45VTdEaz0=;OTA1NTBAMzEzNzJlMzEyZTMwTVlqMW9MQkRTUUZIdXlOREl1SWEyNVNTYnJjNXYzRmkvK3NKSEowQWR3OD0=;OTA1NTFAMzEzNzJlMzEyZTMwTDFiWHp6TXFFUloyQUo3cDBlTC9DQi9sb2J0c1U2SWVQelVOdVhYb3ZMST0=;OTA1NTJAMzEzNzJlMzEyZTMwZmhmbDY2aXdlbjNmdzZkRmhLRU1nbWk0MXE4NnNRQ2Z4YnljWktOWTVXOD0=;OTA1NTNAMzEzNzJlMzEyZTMwYVRRbFAxcjNMdkp6T1lrZFZNNmFFUXFuOTVaa2h5Q2YzTHJtMWVhNkM0VT0=;OTA1NTRAMzEzNzJlMzEyZTMwUkprUzJGOVdvUEdmUkpYeHIvYTNZKzBUYXIvbElNUDZpOFBkNVJsMWJEYz0=;OTA1NTVAMzEzNzJlMzEyZTMwTVlqMW9MQkRTUUZIdXlOREl1SWEyNVNTYnJjNXYzRmkvK3NKSEowQWR3OD0=";
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense (MyLicense);


			InitializeComponent ();

#if DEBUG
            HotReloader.Current.Start(this);
#endif

            MainPage = new LoginPage ();
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
