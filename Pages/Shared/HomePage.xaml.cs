using EngHotel.ViewModels.Shared;
using TripBliss.Helpers;

namespace EngHotel.Pages.Shared;

public partial class HomePage : Controls.CustomControl
{
    #region Service
    readonly IGenericRepository Rep;
    readonly Services.Data.ServicesService _service;
    #endregion

    public HomePage(IGenericRepository GenericRep, Services.Data.ServicesService service)
	{
		InitializeComponent();
        Rep = GenericRep;
        _service = service;
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
            More.BindingContext = new MoreViewModel(Rep,_service);
        }
    }
}