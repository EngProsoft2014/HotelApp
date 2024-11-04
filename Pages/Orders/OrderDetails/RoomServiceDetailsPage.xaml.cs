namespace EngHotel.Pages.Orders.OrderDetails;

public partial class RoomServiceDetailsPage : Controls.CustomControl
{
	public RoomServiceDetailsPage()
	{
		InitializeComponent();
	}



    private void TapGestureRecognizer_RoomEssentials(object sender, TappedEventArgs e)
    {
        if (RoomEssentials.IsVisible == false)
        {
            RoomEssentials.IsVisible = true;
        }
        else
        {
            RoomEssentials.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_RoomAppliances(object sender, TappedEventArgs e)
    {
        if (RoomAppliances.IsVisible == false)
        {
            RoomAppliances.IsVisible = true;
        }
        else
        {
            RoomAppliances.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_Beverage(object sender, TappedEventArgs e)
    {
        if (Beverage.IsVisible == false)
        {
            Beverage.IsVisible = true;
        }
        else
        {
            Beverage.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_Others(object sender, TappedEventArgs e)
    {
        if (Others.IsVisible == false)
        {
            Others.IsVisible = true;
        }
        else
        {
            Others.IsVisible = false;
        }
    }
}