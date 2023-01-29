namespace CreditCardCheckOutSample.Views;

public partial class CheckOutPage : ContentPage
{
	public CheckOutPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.CardsViewModel();
    }
}
