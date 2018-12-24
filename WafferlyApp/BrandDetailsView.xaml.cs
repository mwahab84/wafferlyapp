using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using WafferlyApp.Models;
using Xamarin.Forms;

namespace WafferlyApp
{
    public partial class BrandDetailsView : ContentPage
    {

        public BrandDetailsView()
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

            private const string uri = "http://localhost:5000/api/en/items";
            private int itemsCount, tempCount = 0;
            HttpClient client;
            ObservableCollection<Item> itemsList = new ObservableCollection<Item>();

            //AbsoluteLayout prod;
            //ActivityIndicator serviceLoadingInd;

            protected override void OnAppearing()
            {
                // Set itemsCount and tempCount = 0
                // Retrieve itemsList from the web service
                // Then update itemsCount = TotalItemsinList
                // On Appearing if itemsCount != tempCount Then stop
                // Elseif itemsCount = tempCount Then retrieve updated itemsList

                // In Background Process:
                // Compare TotalItemsinList to itemsCount
                // If itemsCount = TotalItemsinList Then nothing
                // Else Update tempCount = itemsCount Then
                // retrieved updated itemsList
                if (itemsCount != tempCount)
                    return;
                GetItems();

            }

            public void Handle_Tapped(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            protected async void GetItems(string keyword = null)
            {

                client = new HttpClient();
                //client.BaseAddress = uri; // I have changed the Uri variabele, you should extend this class and give it the same base address in the constructor.
                HttpResponseMessage resp = new HttpResponseMessage();

                try
                {
                    //this to start showing the activity indicator
                    //until the app connects to the web service and populates the list view
                    itemsListView.IsVisible = false;
                    serviceInd.IsRunning = true;

                    if (String.IsNullOrWhiteSpace(keyword))
                    {
                        //call the message response of the service
                        resp = await client.GetAsync(uri);
                    }
                    else
                    {
                        //call the message response from the service
                        // api/items/find/{keyword}
                        resp = await client.GetAsync(uri + "/find/" + keyword);
                    }

                    //Success code of Get verb is 200, if returned
                    // deserialize the retrieved list of items and then
                    //assign the items source to the list view
                    if (resp.IsSuccessStatusCode)
                    {
                        var repStr = await resp.Content.ReadAsStringAsync();

                        var _itemsList = JsonConvert.DeserializeObject<List<Item>>(repStr);
                        //to enable the list view to feel the change may happen in the items list
                        itemsList = new ObservableCollection<Item>(_itemsList);
                        itemsListView.ItemsSource = itemsList;
                        itemsCount = itemsList.Count();
                    }
                    //pause for 2 seconds to ensure itemsList populated successfully
                    //then show it and hide the activity indicator
                    await Task.Delay(125).ContinueWith((arg) =>
                    {
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            serviceInd.IsRunning = false;
                            itemsListView.IsVisible = true;
                        });
                    });


                }
                catch (Exception e)
                {

                    //in case failed connection raise a handled error message
                    await DisplayAlert("Connection Error!", "Please check your connection\n Or Server may be down at the moment\n Please try again later!", "OK");
                    serviceInd.IsRunning = false;
                    itemsListView.IsVisible = true;
                }

            }

            void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
            {
                GetItems(e.NewTextValue);
                itemsListView.ItemsSource = itemsList;
            }

            void SearchBar_SearchButtonPressed(object sender, EventArgs e)
            {
                var searchBar = (SearchBar)sender;
                if (String.IsNullOrWhiteSpace(searchBar.Text))
                {
                    GetItems();
                }
                else
                {
                    GetItems(searchBar.Text);
                }

                itemsListView.ItemsSource = itemsList;
            }

            async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem == null)
                    return;

                Item selectedItem = e.SelectedItem as Item;
                await Navigation.PushAsync(new ItemDetailsView() { BindingContext = selectedItem });
                itemsListView.SelectedItem = null;
            }

            void listView_Refreshing(object sender, EventArgs e)
            {
                GetItems();
                itemsListView.ItemsSource = itemsList;
                itemsListView.EndRefresh();
            }
            async void About_Activated(object sender, EventArgs e)
            {

                IPopupNavigation instance;
                instance = PopupNavigation.Instance;

                await instance.PushAsync(new AboutView(), true);

                //await DisplayAlert("","","");

            }

            void Cart_Activated(object sender, EventArgs e)
            {
                DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
            }

            void AddToCart_Clicked(object sender, EventArgs e)
            {
                DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
        }

        void Back_Tapped(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
