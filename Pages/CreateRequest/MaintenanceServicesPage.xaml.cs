namespace EngHotel.Pages.CreateRequest;

public partial class MaintenanceServicesPage : Controls.CustomControl
{
	public MaintenanceServicesPage()
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