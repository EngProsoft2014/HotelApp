using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared;
using EngHotel.ViewModels.Shared;
using System.Collections.ObjectModel;

namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class HousekeepingServicesDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public HousekeepingServicesDetailsViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel
            {
                OrderCount = 1,
                ServiceName = "Full Room Cleaning"
            });
            RoomEssentials.Add(new ServiceModel
            {
                OrderCount = 1,
                ServiceName = "Bathroom Cleaning"
            });
            RoomEssentials.Add(new ServiceModel
            {
                OrderCount = 1,
                ServiceName = "Vacuuming Only"
            });
            RoomEssentials.Add(new ServiceModel
            {
                OrderCount = 1,
                ServiceName = "Trash Removal Only"
            });
            RoomEssentials.Add(new ServiceModel
            {
                OrderCount = 1,
                ServiceName = "Fresh Bed Linen"
            });
            RoomEssentials.Add(new ServiceModel
            {
                OrderCount = 1,
                ServiceName = "Window Cleaning"
            });

        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        [RelayCommand]
        async Task NotesClick()
        {
            var vm = new NotesViewModel();
            var page = new NotesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
