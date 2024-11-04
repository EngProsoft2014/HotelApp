namespace EngHotel.Pages.Orders.OrderDetails;

public partial class ChildcareServicesDetailsPage : Controls.CustomControl
{
	public ChildcareServicesDetailsPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Babysitting(object sender, TappedEventArgs e)
    {
        if (Babysitting.IsVisible == false)
        {
            Babysitting.IsVisible = true;
        }
        else
        {
            Babysitting.IsVisible = false;
        }
    }
}