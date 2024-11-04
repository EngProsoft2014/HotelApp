namespace EngHotel.Pages.Orders.OrderDetails;

public partial class LuggageServicesDetailsPage : Controls.CustomControl
{
	public LuggageServicesDetailsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_LuggageHandling(object sender, TappedEventArgs e)
    {
        if (LuggageHandling.IsVisible == false)
        {
            LuggageHandling.IsVisible = true;
        }
        else
        {
            LuggageHandling.IsVisible = false;
        }
    }
}