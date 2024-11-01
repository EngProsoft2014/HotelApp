using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared.dashboard;
using EngHotel.Pages.Shared.Dining;
using EngHotel.Pages.Shared.User;
using EngHotel.ViewModels.Shared.dashboard;
using EngHotel.ViewModels.Shared.Dining;
using EngHotel.ViewModels.User.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class MoreViewModel : BaseViewModel
    {

        [RelayCommand]
        async Task UsersCLick()
        {
            var vm = new UsersViewModel();
            var page = new UsersPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task DiningCLick()
        {
            var vm = new DiningMenuViewModel();
            var page = new DiningMenuPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }

        [RelayCommand]
        async Task DashBoardCLick()
        {
            var vm = new DashboardViewModels();
            var page = new DashboardPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
