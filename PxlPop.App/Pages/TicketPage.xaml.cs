using MauiIcons.Core;

namespace PxlPop.App.Pages;

public partial class TicketPage : ContentPage
{
	public TicketPage()
	{
		InitializeComponent();

        //_ = new MauiIcon(); // Bugfix for MauiIcon
    }

    private async void OnOrderClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(OrderPage));
    }
}