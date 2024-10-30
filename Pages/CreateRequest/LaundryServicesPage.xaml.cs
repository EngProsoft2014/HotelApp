namespace EngHotel.Pages.CreateRequest;

public partial class LaundryServicesPage : Controls.CustomControl
{
	public LaundryServicesPage()
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