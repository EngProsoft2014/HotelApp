namespace EngHotel.Pages.Orders.OrderDetails;

public partial class MaintenanceServicesDetailsPage : Controls.CustomControl
{
	public MaintenanceServicesDetailsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_RoomIssues(object sender, TappedEventArgs e)
    {
        if (RoomIssues.IsVisible == false)
        {
            RoomIssues.IsVisible = true;
        }
        else
        {
            RoomIssues.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_Furniture(object sender, TappedEventArgs e)
    {
        if (Furniture.IsVisible == false)
        {
            Furniture.IsVisible = true;
        }
        else
        {
            Furniture.IsVisible = false;
        }
    }
}