using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WafferlyApp
{
    public class Location{
        public Location(){
            
        }

        public double Lat
        {
            get;
            set;
        }

        public double Lng
        {
            get;
            set;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VendorsView : ContentPage
    {
        private const string gMapsUri = "https://maps.googleapis.com/maps/api/geocode/json?";
        private const string fqSearchUri = "https://api.foursquare.com/v2/venues/search?";

        string googleApiKey = "AIzaSyAN0i5w3AcsZH96927cDRZMXcNKi1bbwHc";
        string fourSquareCLientid = "IOU2MSIBJGBGXZQSFPFADGC3GWODF1RUNIXYFPSRVAEAXQUB";
        string fourSquareClientSecret = "TEQT2OZSWRBDNNNBSYGDX3ZNCNSKSGAWKQIBFMAAMCRKU1SQ";
        string lat, lng;
        //Dictionary<string,string> latLng = new Dictionary<string, string>();

        public VendorsView()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
            
            getVendorLocation("Wakrah, Qatar","Carrefour");
            //getGeoCodeLocation("Wakrah, Qatar");
		}


        protected async void getGeoCodeLocation(string location){

            var client = new HttpClient();

            location = location.Replace(" ", "+");

            var resp = await client.GetAsync(gMapsUri+"address="+location+"&key="+googleApiKey);

            if (resp.IsSuccessStatusCode)
            {
                var respStr = await resp.Content.ReadAsStringAsync();

                JObject read = JObject.Parse(respStr);
                lat = read["results"][0]["geometry"]["location"]["lat"].ToString();
                lng = read["results"][0]["geometry"]["location"]["lng"].ToString();

                //latLng.Add("ll", lat + "," + lng);
            }

        }

        protected async void getVendorLocation(string location, string vendorName)
        {
            
            var client = new HttpClient();

            location = location.Replace(" ", "+");

            var resp = await client.GetAsync(gMapsUri + "address=" + location + "&key=" + googleApiKey);

            if (resp.IsSuccessStatusCode)
            {
                var respStr = await resp.Content.ReadAsStringAsync();

                JObject read = JObject.Parse(respStr);
                lat = read["results"][0]["geometry"]["location"]["lat"].ToString();
                lng = read["results"][0]["geometry"]["location"]["lng"].ToString();

                //latLng.Add("ll", lat + "," + lng);
            }

            resp = await client.GetAsync(fqSearchUri + "ll=" + lat+","+lng + "&client_id=" +
                                             fourSquareCLientid + "&client_secret=" + fourSquareClientSecret +
                                             "&query=" + vendorName + "&v=20180404&limit=1");

            if (resp.IsSuccessStatusCode)
            {
                var respStr1 = await resp.Content.ReadAsStringAsync();

                JObject read = JObject.Parse(respStr1);


            }
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
