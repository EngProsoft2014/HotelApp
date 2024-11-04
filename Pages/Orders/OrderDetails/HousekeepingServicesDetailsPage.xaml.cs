namespace EngHotel.Pages.Orders.OrderDetails;

public partial class HousekeepingServicesDetailsPage : Controls.CustomControl
{
	public HousekeepingServicesDetailsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_CleaningRequests(object sender, TappedEventArgs e)
    {
        if (CleaningRequests.IsVisible == false)
        {
            CleaningRequests.IsVisible = true;
        }
        else
        {
            CleaningRequests.IsVisible = false;
        }
    }
}