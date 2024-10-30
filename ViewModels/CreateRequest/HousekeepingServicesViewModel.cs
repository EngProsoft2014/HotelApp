using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using System.Collections.ObjectModel;

namespace EngHotel.ViewModels.CreateRequest
{
    public partial class HousekeepingServicesViewModel :BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public HousekeepingServicesViewModel()
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
    }
}
