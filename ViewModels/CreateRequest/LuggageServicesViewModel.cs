using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using System.Collections.ObjectModel;

namespace EngHotel.ViewModels.CreateRequest
{
    public partial class LuggageServicesViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public LuggageServicesViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Request Luggage Pickup",
                OrderCount = 3
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Luggage Storage",
                OrderCount = 9
            });
        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
    }
}
