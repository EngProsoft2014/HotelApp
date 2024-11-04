namespace EngHotel.Pages.Orders.OrderDetails;

public partial class LaundryServicesDetailsPage : Controls.CustomControl
{
	public LaundryServicesDetailsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_WashingServices(object sender, TappedEventArgs e)
    {
        if (WashingServices.IsVisible == false)
        {
            WashingServices.IsVisible = true;
        }
        else
        {
            WashingServices.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_DryCleaning(object sender, TappedEventArgs e)
    {
        if (DryCleaning.IsVisible == false)
        {
            DryCleaning.IsVisible = true;
        }
        else
        {
            DryCleaning.IsVisible = false;
        }
    }
}