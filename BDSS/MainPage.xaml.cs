using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace BDSS
{
    public partial class MainPage : ContentPage
    {

        clsLists cLists = new clsLists();
        int ChapterIndex = 999;
        bool selectableResource = false;


        public MainPage()
        {
            InitializeComponent();
            //webview.Source = "https://uwaterloo.ca/onbase/sites/ca.onbase/files/uploads/files/samplecertifiedpdf.pdf";
            pckChapters.ItemsSource = cLists.chapters;

        }



        void pckChapters_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            vidVideoPlayer.Pause();
            ChapterIndex = pckChapters.SelectedIndex;
            try
            {
                switch (ChapterIndex)
                {
                    
                    case 0:
                        pckContent.ItemsSource = cLists.Chapter0Contents;
                        break;
                    case 1:
                        pckContent.ItemsSource = cLists.Chapter1Contents;
                        break;
                    case 2:
                        pckContent.ItemsSource = cLists.Chapter2Contents;
                        break;
                    case 3:
                        pckContent.ItemsSource = cLists.Chapter3Contents;
                        break;
                    case 4:
                        pckContent.ItemsSource = cLists.Chapter4Contents;
                        break;
                    case 5:
                        pckContent.ItemsSource = cLists.Chapter5Contents;
                        break;
                    case 6:
                        pckContent.ItemsSource = cLists.Chapter6Contents;
                        break;
                    case 7:
                        pckContent.ItemsSource = cLists.Chapter7Contents;
                        break;
                    case 8:
                        pckContent.ItemsSource = cLists.Chapter8Contents;
                        break;
                    case 9:
                        pckContent.ItemsSource = cLists.Chapter9Contents;
                        break;
                    case 10:
                        pckContent.ItemsSource = cLists.Chapter10Contents;
                        break;
                    case 11:
                        pckContent.ItemsSource = cLists.Chapter11Contents;
                        break;
                    case 12:
                        pckContent.ItemsSource = cLists.Chapter12Contents;
                        break;
                    default:

                        break;
                }
            }
            catch (Exception ex)
            {

            }
            pckContent.SelectedIndex = -1;
            selectableResource = false;
            
        }

        async void pckContent_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            // The first step is to find the filename that mathes the resource that
            // was clicked from the picker.  This means matching the index of the contents
            // list with the correct list of resources for the selected chapter

            int resourceIndex = pckContent.SelectedIndex;
            string resourceName = "";

            try
            {
                switch (ChapterIndex)
                {
                    case 0:
                        resourceName = cLists.Chapter0Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 1:
                        resourceName = cLists.Chapter1Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 2:
                        resourceName = cLists.Chapter2Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 3:
                        resourceName = cLists.Chapter3Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 4:
                        resourceName = cLists.Chapter4Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 5:
                        resourceName = cLists.Chapter5Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 6:
                        resourceName = cLists.Chapter6Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 7:
                        resourceName = cLists.Chapter7Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 8:
                        resourceName = cLists.Chapter8Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 9:
                        resourceName = cLists.Chapter9Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 10:
                        resourceName = cLists.Chapter10Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 11:
                        resourceName = cLists.Chapter11Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    case 12:
                        resourceName = cLists.Chapter12Filenames[resourceIndex];
                        selectableResource = true;
                        break;
                    default:
                        break;
                }
             
            }
            catch (Exception ex)
            {

            }

            
            // Now we have to create the full path of the file
            string filename = "http://www.rtmeng.es/BDSS/" + resourceName;

            // now to grab the file extension to determine how the thing gets opened...
            string extension = Path.GetExtension(filename);

            // Now display the resource either in the video player or in the webview
            if (extension == ".mp4" && selectableResource) 
            {
                vidVideoPlayer.Source = filename; 
            }
            else
            {
                if (filename != "http://www.rtmeng.es/BDSS/")
                {
                    vidVideoPlayer.Pause();
                    await Navigation.PushModalAsync(new BDSS.ContentView(filename));
                }
            }
        }


    }
}