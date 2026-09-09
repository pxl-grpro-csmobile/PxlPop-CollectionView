using MauiIcons.Core;
using PxlPop.App.Pages;

namespace PxlPop.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //_ = new MauiIcon();
        }

        private async void OnLineupClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LineupPage), true);
        }

        private async void OnInfoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(InfoPage), true);
        }

        private async void OnTicketsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TicketPage), true);
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage), true);
        }

        private async void OnFavouritesClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FavouritesPage), true);
        }

        private async void OnPageLoaded(object sender, EventArgs e)
        {
            await Task.WhenAny(
                pxlLogo.FadeToAsync(1, 3000),
                pxlLogo.RotateToAsync(360, 3000));
        }
    }

}
