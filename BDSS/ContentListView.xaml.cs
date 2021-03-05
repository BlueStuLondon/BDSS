using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BDSS
{
    public partial class ContentListView : ContentPage
    {

        List<String> contentList = new List<string>()
        {
            "0.  Introduction",
            "1.  Posture",
            "2.  Body preparation (acro, legs tension and plyometrics)",
            "3.  Springboard take-off",
            "4.  Forward and Inward rotation",
            "5.  Back and Reverse rotation",
            "6.  Twist",
            "7.  Armstand",
            "8.  Spotting and entry",
            "9.  Planning training",
            "10. Performance psychology",
            "11. Performance nutrition",
            "12. Professional Conduct"
        };

        static int returnIndex;

        public ContentListView()
        {
            InitializeComponent();
            lstChapterList.ItemsSource = contentList;
        }

        async void btnBack_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        
        async void lstChapterList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            string testme = Convert.ToString(lstChapterList.SelectedItem);
            
            string[] words = testme.Split('.');
            returnIndex = Convert.ToInt16(words[0]);
            
            
            await Navigation.PopModalAsync();

        }
    }
}
