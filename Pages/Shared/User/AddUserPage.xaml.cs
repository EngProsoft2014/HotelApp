using EngHotel.Models.ServicesModels;
using EngHotel.ViewModels.Shared.User;

namespace EngHotel.Pages.Shared.User;

public partial class AddUserPage : ContentPage
{
    AddUserViewModel Model;
    public AddUserPage(AddUserViewModel model)
	{
		InitializeComponent();
        Model = model;
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var cc = CollecServ!.SelectedItem! as serviceModel;
        if (e.Value)
		{
            Model.AddService(cc!);
        }
    }
}