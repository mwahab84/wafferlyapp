using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using System.Reflection;
using Rg.Plugins.Popup.Extensions;

namespace WafferlyApp
{
    public partial class AboutView : PopupPage
    {
        public AboutView()
        {
            InitializeComponent();


        }

         async void btnClose_Pressed(object sender, System.EventArgs e)
        {
            await Navigation.PopAllPopupAsync();
        }
    }
}
