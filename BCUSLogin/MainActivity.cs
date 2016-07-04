using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using BCUSLoginLib;

namespace BCUSLogin
{
	[Activity(Label = "BCUSLogin", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.LoginScreen);

			var testbutton = FindViewById<Button>(Resource.Id.testbutton);

			testbutton.Click += delegate
			{
				Toast.MakeText(this, "testbutton clicked", ToastLength.Long).Show();
				Headers headers = new Headers();

				Log.Info("header.Guid", headers.Guid);
				PROD_URLS prod_urls = new PROD_URLS();
				Log.Info("prod_urls.authenticate", prod_urls.Authenticate
						);
			};

		}
	}
}


