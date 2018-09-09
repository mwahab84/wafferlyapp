using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using Google.MobileAds;
using UIKit;
//using Microsoft.AppCenter;
//using Microsoft.AppCenter.Analytics;
//using Microsoft.AppCenter.Crashes;

namespace WafferlyApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            Rg.Plugins.Popup.Popup.Init();
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
			Xamarin.Calabash.Start();
#endif
            //AppCenter.Start("81c4f5d6-0f57-4129-91d0-8151db0a38c9", typeof(Analytics), typeof(Crashes));

            MobileAds.Configure("ca-app-pub-8844105249330187~9258943587");
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
