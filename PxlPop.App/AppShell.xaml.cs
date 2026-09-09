using PxlPop.App.Pages;

namespace PxlPop.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LineupPage), typeof(LineupPage));
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
            Routing.RegisterRoute(nameof(TicketPage), typeof(TicketPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(FavouritesPage), typeof(FavouritesPage));
            Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
        }
    }
}
