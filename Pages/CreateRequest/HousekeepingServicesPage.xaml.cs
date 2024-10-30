namespace EngHotel.Pages.CreateRequest;

public partial class HousekeepingServicesPage : Controls.CustomControl
{
	public HousekeepingServicesPage()
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