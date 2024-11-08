using EngHotel.ViewModels.Shared.Rooms;

namespace EngHotel.Pages.Shared.Rooms;

public partial class RoomFilterPage : ContentPage
{
	RoomFilterViewModel Model;
    public RoomFilterPage(RoomFilterViewModel model)
	{
		InitializeComponent();
		Model = model;	
	}
}