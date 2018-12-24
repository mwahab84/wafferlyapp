using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using WafferlyApp.Models;
using Xamarin.Forms;

namespace WafferlyApp
{
    public partial class CountriesView : ContentPage
    {
        private List<Country> countryList = new List<Country>();
        public CountriesView()
        {
            InitializeComponent();
            countryList.Add(new Country
            {
                Title = "Qatar",
                CountryFlagPath = "vendorlogo.png",
                            });
            countryList.Add(new Country
            {
                Title = "Egypt",
                CountryFlagPath = "vendorlogo.png"

            });

            countryList.Add(new Country
            {
                Title = "United States of America",
                CountryFlagPath = "vendorlogo.png"
            });

            countryList.Add(new Country
            {
                Title = "Morrocco",
                CountryFlagPath = "vendorlogo.png",//ImageSource.FromResource("vendorlogo").ToString(),

            });

            countryListView.ItemsSource = countryList;
        }
        protected override void OnAppearing()
        {

            //getVendorLocation("Wakrah, Qatar","Carrefour");
            //getGeoCodeLocation("Wakrah, Qatar");
        }
        void listView_Refreshing(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void listView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void SearchBar_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void SearchBar_SearchButtonPressed(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
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
