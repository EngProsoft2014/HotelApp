using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Orders.OrderDetails;
using EngHotel.ViewModels.Orders.OrderDetails;
using Microsoft.AspNet.SignalR.Client.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Orders
{
    public partial class OrderViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<RequestModel> requests = new ObservableCollection<RequestModel>();

        public OrderViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            Requests.Add(new RequestModel { GuestName = "John Doe", RoomId = 101, Status = "Completed", Date = DateTime.Now });
            Requests.Add(new RequestModel { GuestName = "Alice Smith", RoomId = 102, Status = "Pending", Date = DateTime.Now.AddHours(-1) });
            Requests.Add(new RequestModel { GuestName = "Bob Johnson", RoomId = 103, Status = "Progress", Date = DateTime.Now.AddDays(-1) });
            Requests.Add(new RequestModel { GuestName = "Emma Davis", RoomId = 104, Status = "Completed", Date = DateTime.Now.AddMinutes(-30) });
            Requests.Add(new RequestModel { GuestName = "Liam Brown", RoomId = 105, Status = "Pending", Date = DateTime.Now.AddDays(-2) });
            Requests.Add(new RequestModel { GuestName = "Olivia Wilson", RoomId = 106, Status = "Completed", Date = DateTime.Now.AddHours(-3) });
            Requests.Add(new RequestModel { GuestName = "Noah Martinez", RoomId = 107, Status = "Pending", Date = DateTime.Now.AddDays(-3) });
            Requests.Add(new RequestModel { GuestName = "Sophia Anderson", RoomId = 108, Status = "Progress", Date = DateTime.Now.AddHours(-2) });
            Requests.Add(new RequestModel { GuestName = "James Lee", RoomId = 109, Status = "Completed", Date = DateTime.Now.AddMinutes(-15) });
            Requests.Add(new RequestModel { GuestName = "Mia Taylor", RoomId = 110, Status = "Pending", Date = DateTime.Now.AddDays(-5) });
        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task SelectItemClick()
        {
            var vm = new OrderDetailsViewModel();
            var page = new OrderDetailsPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
