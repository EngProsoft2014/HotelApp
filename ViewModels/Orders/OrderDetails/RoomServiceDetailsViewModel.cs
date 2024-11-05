using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared;
using EngHotel.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class RoomServiceDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public RoomServiceDetailsViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Extra Bed",
                OrderCount = 3
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Extra Pillow",
                OrderCount = 9
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Extra Bed Cover",
                OrderCount = 7
            });
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Extra Bed Sheet",
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
