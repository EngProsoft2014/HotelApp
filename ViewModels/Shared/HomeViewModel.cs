using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.CreateRequest;
using EngHotel.ViewModels.CreateRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class HomeViewModel : BaseViewModel
    {

        [RelayCommand]
        async Task RoomServiceClick()
        {
            var vm = new RoomServiceViewModel();
            var page = new RoomServicePage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task BathroomServicesClick()
        {
            var vm = new BathroomServicesViewModel();
            var page = new BathroomServicesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task HousekeepingServicesClick()
        {
            var vm = new HousekeepingServicesViewModel();
            var page = new HousekeepingServicesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task LaundryServicesClick()
        {
            var vm = new LaundryServicesViewModel();
            var page = new LaundryServicesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task MaintenanceServicesClick()
        {
            var vm = new MaintenanceServicesViewModel();
            var page = new MaintenanceServicesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
