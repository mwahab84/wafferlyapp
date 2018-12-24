using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using WafferlyApp.Models;
using Xamarin.Forms;

namespace WafferlyApp
{
    public partial class BrandsView : ContentPage
    {
        private List<Brand> brandList = new List<Brand>();
        public BrandsView()
        {
            InitializeComponent();
            brandList.Add(new Brand
            {
                Title = "Carrefour",
                Desc = "This is a lite description about the vendor",
                BrandLogoPath = "vendorlogo.png"});
            brandList.Add(new Brand
            {
                Title = "Al Meera",
                Desc = "This is a lite description about Al Meera",
                BrandLogoPath = "vendorlogo.png"
            });

            brandList.Add(new Brand
            {
                Title = "Family Shopping Centre",
                Desc = "This is a lite description about Family Shopping Centre",
                BrandLogoPath = "vendorlogo.png"
            });

            brandList.Add(new Brand
            {
                Title = "Retail Mart",
                Desc = "This is a lite description about Retail Mart",
                BrandLogoPath = "vendorlogo.png"
            });

            brandsListView.ItemsSource = brandList;
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
