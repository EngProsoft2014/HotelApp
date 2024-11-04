namespace EngHotel.Pages.Orders.OrderDetails;

public partial class BathroomServicesDetailsPage : Controls.CustomControl
{
	public BathroomServicesDetailsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_TowelRequests(object sender, TappedEventArgs e)
    {
        if (TowelRequests.IsVisible == false)
        {
            TowelRequests.IsVisible = true;
        }
        else
        {
            TowelRequests.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_ToiletryRequests(object sender, TappedEventArgs e)
    {
        if (ToiletryRequests.IsVisible == false)
        {
            ToiletryRequests.IsVisible = true;
        }
        else
        {
            ToiletryRequests.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_BathroomAmenities(object sender, TappedEventArgs e)
    {
        if (BathroomAmenities.IsVisible == false)
        {
            BathroomAmenities.IsVisible = true;
        }
        else
        {
            BathroomAmenities.IsVisible = false;
        }
    }
}