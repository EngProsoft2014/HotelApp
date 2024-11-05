using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared;
using EngHotel.ViewModels.Shared;
using System.Collections.ObjectModel;

namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class LaundryServicesDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public LaundryServicesDetailsViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Shirts & Blouses",
                OrderCount = 3
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Pants & Jeans",
                OrderCount = 9
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Dresses",
                OrderCount = 7
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Underwear & Socks",
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
