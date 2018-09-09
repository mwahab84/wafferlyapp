using System;

using WafferlyApp.Controls;
using Google.MobileAds;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using WafferlyApp.iOS.PlatformSpecific;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdViewRenderer))]
namespace WafferlyApp.iOS.PlatformSpecific
{
 

    public class AdViewRenderer:ViewRenderer<AdControlView,BannerView>
    {
        BannerView adView;
        bool viewOnScreen;

		
        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            if (e.OldElement == null)
            {
                adView = new BannerView(AdSizeCons.SmartBannerPortrait)
                {
                    AdUnitID = "ca-app-pub-8844105249330187/6917110450",
                    RootViewController = GetRootViewController()
                };

                adView.AdReceived += (sender, args) =>
                {
                    if (!viewOnScreen) this.AddSubview(adView);
                    viewOnScreen = true;
                };

                var request = Request.GetDefaultRequest();

                //e.NewElement.HeightRequest = GetSmartBannerDpHeight();
                adView.LoadRequest(request);

                base.SetNativeControl(adView);
            }
        }

        private UIViewController GetRootViewController()
        {
            foreach (UIWindow window in UIApplication.SharedApplication.Windows)
            {
                if (window.RootViewController != null)
                {
                    return window.RootViewController;
                }
            }

            return null;
        }

    }
}
