using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BDSS
{
    public partial class ContentView : ContentPage
    {
        public ContentView(string filename)
        {
            InitializeComponent();
            try
            {
                wbvContent.Source = filename;
            }
            catch (Exception ex)
            {
                Navigation.PopModalAsync();
            }
            
        }

        async void btnBack_Clicked(System.Object sender, System.EventArgs e)
        {
            
            await Navigation.PopModalAsync();
        }
    }
}
