using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;
using WafferlyApp.Controls;
using WafferlyApp.Droid.Helpers;
using Android.Content;
using Android.Widget;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdViewRenderer))]
namespace WafferlyApp.Droid.Helpers
{
    public class AdViewRenderer:ViewRenderer<AdControlView,AdView>
    {
        public AdViewRenderer(Context context): base(context){
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var ad = new AdView(Context)
                {
                    AdSize = AdSize.SmartBanner,
                    AdUnitId = "ca-app-pub-8844105249330187/6261670185"
                };

                var requestbuilder = new AdRequest.Builder();

                ad.LoadAd(requestbuilder.Build());

                SetNativeControl(ad);
            }
        }

	}
}
