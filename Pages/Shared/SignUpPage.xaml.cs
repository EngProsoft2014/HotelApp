namespace EngHotel.Pages.Shared;

public partial class SignUpPage : Controls.CustomControl
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        entryPassword.IsPassword = (entryPassword.IsPassword == true) ? false : true;
    }
}