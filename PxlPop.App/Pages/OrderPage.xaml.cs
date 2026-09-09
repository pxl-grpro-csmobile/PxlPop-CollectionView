namespace PxlPop.App.Pages;

public partial class OrderPage : ContentPage
{
    public OrderPage()
    {
        InitializeComponent();
    }

    private async void OnPaymentClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage", true);
    }

    private async void OnEmailCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        await addressLayout.FadeToAsync(e.Value ? 0 : 1, 2000);
        addressLayout.Opacity = e.Value ? 0 : 1;
    }


}