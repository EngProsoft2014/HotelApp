using Akavache;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Orders;
using EngHotel.Pages.Shared;
using EngHotel.Pages.Shared.dashboard;
using EngHotel.Pages.Shared.Dining;
using EngHotel.Pages.Shared.Rooms;
using EngHotel.Pages.Shared.User;
using EngHotel.ViewModels.Orders;
using EngHotel.ViewModels.Shared.dashboard;
using EngHotel.ViewModels.Shared.Dining;
using EngHotel.ViewModels.Shared.Rooms;
using EngHotel.ViewModels.User.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared
{
    public partial class MoreViewModel : BaseViewModel
    {
        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        public MoreViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service)
        {
            Rep = GenericRep;
            _service = service;
        }

        #region RelayCommand
        [RelayCommand]
        async Task UsersCLick()
        {
            var vm = new UsersViewModel(Rep, _service);
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

        [RelayCommand]
        async Task RoomCLick()
        {
            var vm = new RoomViewModel();
            var page = new RoomsPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }

        [RelayCommand]
        async Task OrdersCLick()
        {
            var vm = new OrderViewModel();
            var page = new OrderPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }

        [RelayCommand]
        [Obsolete]
        Task ExitClick()
        {
            Action action = async () =>
            {
                string LangValueToKeep = Preferences.Default.Get("Lan", "en");
                Preferences.Default.Clear();
                await BlobCache.LocalMachine.InvalidateAll();
                await BlobCache.LocalMachine.Vacuum();
                Constants.Permissions.LstPermissions.Clear();

                Preferences.Default.Set("Lan", LangValueToKeep);
                var vm = new OnBordingViewModel(Rep, _service);
                var page = new OnBordingPage();
                page.BindingContext = vm;
                App.Current!.MainPage = new NavigationPage(page);
            };
            Controls.StaticMember.ShowSnackBar("Do you want to Logout", Controls.StaticMember.SnackBarColor, Controls.StaticMember.SnackBarTextColor, action);
            return Task.CompletedTask;
        }
        #endregion
    }
}
