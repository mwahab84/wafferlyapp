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
using Xamarin.Forms.Xaml;

namespace WafferlyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsView : ContentPage
    {
		private const string uri = "https://api.wafferly.net/api/items";
        private int itemsCount,tempCount = 0;
        HttpClient client;
        ObservableCollection<Item> itemsList = new ObservableCollection<Item>();
        //AbsoluteLayout prod;
        //ActivityIndicator serviceLoadingInd;

        public ItemsView()
        {
            InitializeComponent();

        }


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


		protected async void GetItems(string keyword = null)
        {
       
            client = new HttpClient();
            //client.BaseAddress = uri; // I have changed the Uri variabele, you should extend this class and give it the same base address in the constructor.
            HttpResponseMessage resp = new HttpResponseMessage();

            try
            {
                //this to start showing the activity indicator
                //until the app connects to the web service and populates the list view
                //itemsListView.IsVisible = false;
                serviceInd.IsRunning = true;

                if (String.IsNullOrWhiteSpace(keyword))
                {
                    //call the message response of the service
                    resp = await client.GetAsync(uri);
                }
                else{
                    //call the message response from the service
                    // api/items/find/{keyword}
                    resp = await client.GetAsync(uri+"/find/"+keyword);
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
                await Task.Delay(500).ContinueWith((arg) => {
                    Device.BeginInvokeOnMainThread(() => {
                        serviceInd.IsRunning = false;
                        //itemsListView.IsVisible = true;
                    });
                });


            }
            catch (Exception e)
            {
                
                //in case failed connection raise a handled error message
                await DisplayAlert("Connection Error!", "Please check your connection\n Or Server may be down at the moment\n Please try again later!", "OK");
                serviceInd.IsRunning = false;
                //itemsListView.IsVisible = true;
            }

        }

        void SearchBar_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
                GetItems(e.NewTextValue);
                itemsListView.ItemsSource = itemsList; 
        }

        void SearchBar_SearchButtonPressed(object sender, System.EventArgs e)
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

        async void listView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            Item selectedItem = e.SelectedItem as Item;
            await Navigation.PushAsync(new ItemDetailsView() { BindingContext = selectedItem });
            itemsListView.SelectedItem = null;
        }

        void listView_Refreshing(object sender, System.EventArgs e)
        {
            GetItems();
            itemsListView.ItemsSource = itemsList;
            itemsListView.EndRefresh();
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

        void AddToCart_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Information", "This feature coming soon\nStay tuned!", "OK");
        }
    }
}
