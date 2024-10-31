namespace EngHotel.Pages.CreateRequest;

public partial class LuggageServicesPage : Controls.CustomControl
{
	public LuggageServicesPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_LuggageHandling(object sender, TappedEventArgs e)
    {
        if (LuggageHandling.IsVisible == false)
        {
            LuggageHandling.IsVisible = true;
        }
        else
        {
            LuggageHandling.IsVisible = false;
        }
    }
}