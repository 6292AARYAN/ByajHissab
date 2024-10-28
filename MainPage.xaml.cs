using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using System;

namespace BYAJHISSAB
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var popup = new MainPopup();
            this.ShowPopup(popup);
        }


    }

}
