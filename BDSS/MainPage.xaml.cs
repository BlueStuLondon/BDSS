using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace BDSS
{
    public partial class MainPage : ContentPage
    {
        public static int ChapIndex { get; set; }
        public MainPage()
        {
            InitializeComponent();
            webview.Source = "https://uwaterloo.ca/onbase/sites/ca.onbase/files/uploads/files/samplecertifiedpdf.pdf";
            ChapIndex = 999;

        }

        private void ShowMeTheMoney(int x)
        {
            x += 2;
        }

        async void btnChapters_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ContentListView());
            if (ChapIndex != 999)
            {
                ShowMeTheMoney(ChapIndex);
            }
           
        }

        async void btncontent_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ContentView());
            
        }
    }

    
}
