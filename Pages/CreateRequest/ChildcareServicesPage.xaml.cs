namespace EngHotel.Pages.CreateRequest;

public partial class ChildcareServicesPage : Controls.CustomControl
{
	public ChildcareServicesPage()
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