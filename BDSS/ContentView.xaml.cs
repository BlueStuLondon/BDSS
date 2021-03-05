using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BDSS
{
    public partial class ContentView : ContentPage
    {
        public ContentView()
        {
            InitializeComponent();
            wbvContent.Source = "file:///Users/stuartmenges/Documents/GitHub/BDSS/BDSS.iOS/Resources/FAIR.pdf";
        }

        async void btnBack_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
