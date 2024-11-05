using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared;
using EngHotel.ViewModels.Shared;
using System.Collections.ObjectModel;

namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class MaintenanceServicesDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public MaintenanceServicesDetailsViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Electrical Issues",
                OrderCount = 3
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Plumbing Issues",
                OrderCount = 9
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Air Conditioning Issues",
                OrderCount = 7
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Appliance & Equipment Repair",
                OrderCount = 5
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Miscellaneous",
                OrderCount = 5
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
