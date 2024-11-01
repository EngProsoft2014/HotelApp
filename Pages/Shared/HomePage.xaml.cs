using EngHotel.ViewModels.Shared;

namespace EngHotel.Pages.Shared;

public partial class HomePage : Controls.CustomControl
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void SfTabView_SelectionChanged(object sender, Syncfusion.Maui.TabView.TabSelectionChangedEventArgs e)
    {
		if(e.NewIndex == 1)
		{
            CartView.BindingContext = new CartViewModel();
        }
		else if(e.NewIndex == 2)
		{
			History.BindingContext = new HistoryViewModel();
		}
		else if (e.NewIndex == 3)
		{
            More.BindingContext = new MoreViewModel();
        }
    }
}