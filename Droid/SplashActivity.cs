
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace WafferlyApp.Droid
{
    [Activity(Label = "Wafferly", Icon = "@drawable/icon",
              Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            System.Threading.Thread.Sleep(1000);
            this.StartActivity(typeof(MainActivity));
        }
    }
}
