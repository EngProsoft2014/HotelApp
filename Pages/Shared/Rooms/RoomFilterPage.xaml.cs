using EngHotel.ViewModels.Shared.Rooms;

namespace EngHotel.Pages.Shared.Rooms;

public partial class RoomFilterPage : Controls.CustomControl
{
	RoomFilterViewModel Model;
    public RoomFilterPage(RoomFilterViewModel model)
	{
		InitializeComponent();
		Model = model;	
	}
}