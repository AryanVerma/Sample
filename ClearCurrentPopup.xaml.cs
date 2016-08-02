
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

namespace App3
{
	public partial class ClearCurrentPopup : PopupPage
    {
        bool imageTapped = false;
        public ClearCurrentPopup()
        {
            InitializeComponent();
            Animation = new UserAnimation();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            if (Device.OS == TargetPlatform.Android)
            {
                CheckOrUnCheckImg.TranslationX = 90;
                ClearFileInfoLabel.FontSize = 30;
                ClearFileInfoLabel.TranslationX = 120;
            }
            if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.WinPhone)
            {
                OKButton.IsEnabled = false;
                if (OKButton.IsEnabled)
                {
                    btnLayout.BackgroundColor = Color.Green;
                }
                OKButton.WidthRequest = 100;
                CancelButton1.WidthRequest = 100;
                ClearFileInfoLabel.TranslationX = 130;
                CheckOrUnCheckImg.TranslationX = 100;
            }
            base.OnAppearing();
        }

        private async void OnOk(object sender, EventArgs e)
        {

          
                await PopupNavigation.PopAsync(false);
           


        }

        private async void OnCancel(object sender, EventArgs e)
        {
          
           
                await PopupNavigation.PopAsync(false);
            
        }
        private async void OnClose(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }
        void CheckMarkTapped(object sender, EventArgs args)
        {
            if (imageTapped == false)
            {
                CheckOrUnCheckImg.Source = "check.png";
                imageTapped = true;
                OKButton.BackgroundColor = Color.FromHex("70B856");
                OKButton.IsEnabled = true;
            }

            else
            {
                OKButton.IsEnabled = false;
                OKButton.BackgroundColor = Color.Silver;
                CheckOrUnCheckImg.Source = "uncheck.png";
                imageTapped = false;
            }
        }

    }
}
