using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using System.Collections.ObjectModel;

namespace EngHotel.ViewModels.CreateRequest
{
    public partial class ChildcareServicesViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ServiceModel> roomEssentials = new ObservableCollection<ServiceModel>();

        public ChildcareServicesViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            RoomEssentials.Add(new ServiceModel()
            {
                IsSelectes = false,
                ServiceName = "Book Babysitter",
                OrderCount = 3
            });
        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
    }
}
