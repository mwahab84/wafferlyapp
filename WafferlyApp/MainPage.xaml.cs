using System;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace WafferlyApp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void About_Clicked(object sender, EventArgs e)
        {
            IPopupNavigation instance;
            instance = PopupNavigation.Instance;

            await instance.PushAsync(new AboutView(), true);
        }

        public async void Cart_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
        }

        public async void SearchItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsView());
        }


        public async void InternationalItems_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsView());
        }

        public async void Stack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsView());
        }
    }
}
