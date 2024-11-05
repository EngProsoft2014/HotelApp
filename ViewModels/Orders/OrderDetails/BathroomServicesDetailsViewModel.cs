using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared;
using EngHotel.ViewModels.Shared;
using System.Collections.ObjectModel;


namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class BathroomServicesDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public BathroomServicesDetailsViewModel()
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
