using Syncfusion.Maui.Core.Carousel;

namespace EngHotel.Pages.Shared;

public partial class LoginPage : Controls.CustomControl
{
	public LoginPage()
	{
		InitializeComponent();

        entryEmail.Completed += (object sender, EventArgs e) =>
        {
            entryPassword.Focus();
        };
        entryPassword.Completed += (object sender, EventArgs e) =>
        {
            //ViewModel.ClickLoginCommand.Execute(ViewModel.LoginRequest);
        };
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        entryPassword.IsPassword = (entryPassword.IsPassword == true) ? false : true;
    }
}