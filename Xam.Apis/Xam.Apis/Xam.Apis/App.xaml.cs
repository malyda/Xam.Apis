using Xam.Apis.View.Page;
using Xam.Apis.View.Page.MasterDetailPageApis;
using Xamarin.Forms;

namespace Xam.Apis
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MasterDetailPageApis();
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
