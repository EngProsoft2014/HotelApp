using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared.Rooms
{
    public partial class AddRoomViewModel : BaseViewModel
    {


        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        [RelayCommand]
        async Task AddImageClick()
        {
            var vm = new ImagesViewModel();
            var page = new ImagesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
