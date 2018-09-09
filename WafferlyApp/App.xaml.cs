using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;
namespace WafferlyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppCenter.Start("android=e37f922b-1460-41e1-9bcd-fd4c622ab8a6;" +
                            "ios=81c4f5d6-0f57-4129-91d0-8151db0a38c9",
                            typeof(Analytics), typeof(Crashes),typeof(Push));

            MainPage = new NavigationPage(new ItemsView());

            /*   protected override void OnStart()
               {
                   // Handle when your app starts
               }

               protected override void OnSleep()
               {
                   // Handle when your app sleeps
               }

               protected override void OnResume()
               {
                   // Handle when your app resumes
               }*/
        }
    }
}
