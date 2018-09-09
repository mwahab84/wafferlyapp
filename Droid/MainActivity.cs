using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using Android.Gms.Ads;
//using Microsoft.AppCenter.Analytics;
//using Microsoft.AppCenter.Crashes;

namespace WafferlyApp.Droid
{
    [Activity(Label = "Wafferly", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);


            //AppCenter.Start("e37f922b-1460-41e1-9bcd-fd4c622ab8a6", typeof(Analytics), typeof(Crashes));

            MobileAds.Initialize(ApplicationContext, "ca-app-pub-8844105249330187~4536497303");
            Push.SetSenderId("586898794466");

            LoadApplication(new App());
        }

	}
}
