using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using WafferlyApp.Models;
using Xamarin.Forms;

namespace WafferlyApp
{
    public partial class CategoriesView : ContentPage
    {
        private List<Category> specialOffersList = new List<Category>();
        private List<Category> categoryList = new List<Category>();
        public CategoriesView()
        {
            InitializeComponent();
            specialOffersList.Add(new Category
            {
                Title = "Special Offers",
                Desc = "This is a lite description about Special Offers",
                CatImagePath = "vendorlogo.png"
            });
            categoryList.Add(new Category
            {
                Title = "Groceries",
                Desc = "This is a lite description about groceries",
                CatImagePath = "vendorlogo.png"});
            categoryList.Add(new Category
            {
                Title = "Vegetables",
                Desc = "This is a lite description about vegetables",
                CatImagePath = "vendorlogo.png"});

            categoryList.Add(new Category
            {
                Title = "Fruits",
                Desc = "This is a lite description about fruits",
                CatImagePath = "vendorlogo.png"});

            categoryList.Add(new Category
            {
                Title = "Home Appliances",
                Desc = "This is a lite description about home appliances",
                CatImagePath = "vendorlogo.png"});

            specialOffersView.ItemsSource = specialOffersList;
            categoryListView.ItemsSource = categoryList;
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
