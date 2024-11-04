using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace EngHotel.ViewModels.Shared.Rooms
{
    public partial class RoomViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<MealModel> roomLst = new ObservableCollection<MealModel>();

        public RoomViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomLst.Add(new MealModel { MealName = "Deluxe room", Classfication = "30" });
            RoomLst.Add(new MealModel { MealName = "Suite", Classfication = "16" });
            RoomLst.Add(new MealModel { MealName = "Double room", Classfication = "26" });
            RoomLst.Add(new MealModel { MealName = "Connecting rooms", Classfication = "8" });

        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task AddRoomClick()
        {
            var vm = new AddRoomViewModel();
            var page = new AddRoomPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
