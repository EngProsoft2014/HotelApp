using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using System.Collections.ObjectModel;


namespace EngHotel.ViewModels.CreateRequest
{
    public partial class BathroomServicesViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public BathroomServicesViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Shampoo"
            });
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Conditioner"
            });
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Body Wash"
            });
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Soap"
            });
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Toothpaste"
            });
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Razor"
            });
            RoomEssentials.Add(new ServiceModel()
            {
                OrderCount = 4,
                ServiceName = "Extra Shower Cap"
            });

        }
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
    }
}
