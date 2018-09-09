using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace WafferlyApp
{
    public partial class ItemDetailsView : ContentPage
    {

        public ItemDetailsView()
        {
            InitializeComponent();
            //ItemImage.Source = ImageSource.FromResource("WafferlyApp.Images.potato.jpg");
            //offerImage.Source = ImageSource.FromResource("WafferlyApp.Images.specialOffer.png");
            //var vendorImageSource = new UriImageSource { Uri = new Uri("http://bit.ly/carre4logo")};
            //vendorImageSource.CachingEnabled = true;
            //vendorImageSource.CacheValidity = TimeSpan.FromHours(1);
            //test.Source = vendorImageSource;
            //btnVendor.Image = (FileImageSource)vendorImageSource;
            //btnVendor.Image = (FileImageSource) ImageSource.FromUri(new Uri("http://bit.ly/carre4logo"));
            //VendorLogo.Source = ImageSource.FromUri(new Uri("https://lh3.googleusercontent.com/ONADEj6LnVm7KQ3IaFZOstEWJ-H-T6ZVCZoBUBNODdGQtlHWL87OA8dO9rjcrwbqB1Q=w300-rw"));
            //btnVendor.GestureRecognizers.Add(new TapGestureRecognizer() { CommandParameter = BindingContext{}});
        }

          void VendorLogo_Pressed(object sender, System.EventArgs e)
        {

            DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
            //await Navigation.PushAsync(new VendorsView(),true);
        }

         void Handle_Focused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
            //await Navigation.PushAsync(new VendorsView());

        }

        async void About_Activated(object sender, System.EventArgs e)
        {

            IPopupNavigation instance;
            instance = PopupNavigation.Instance;

            await instance.PushAsync(new AboutView(), true);

            //await DisplayAlert("","","");

        }

        void Cart_Activated(object sender, System.EventArgs e)
        {
            
            DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
        }
    }
}
