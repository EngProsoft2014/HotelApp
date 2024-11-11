using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Controls.UserDialogs.Maui;
using EngHotel.Constants;
using EngHotel.Models.BookingModels;
using EngHotel.Models.RoomModels;
using EngHotel.Pages.Shared.Rooms;
using EngHotel.ViewModels.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared
{
    public partial class BookingViewModel : BaseViewModel
    {
        [ObservableProperty]
        BookingModel booking = new BookingModel();

        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        public BookingViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service)
        {
            Rep = GenericRep;
            _service = service;
        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        [RelayCommand]
        async Task RoomNumClick()
        {
            var vm = new RoomFilterViewModel(Rep,_service,Booking.CheckInDate,Booking.CheckOutDate);
            vm.RoomFilterClose += (RoomModel) =>
            {
                Booking.RoomId = RoomModel.ID;
            };
            var page = new RoomFilterPage(vm);
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task BookingClick(BookingModel model)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                string UserToken = await _service.UserToken();
                if (string.IsNullOrEmpty(model.GuestName))
                {
                    var toast = Toast.Make("Guest Name is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model.GuestContact))
                {
                    var toast = Toast.Make("Guest Contact is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.BookingDate < DateTime.Now.AddDays(-1))
                {
                    var toast = Toast.Make("Booking Date not valied", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model.NumberofGuests))
                {
                    var toast = Toast.Make("Number of Guests is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.CheckInDate < DateTime.Now.AddDays(-1))
                {
                    var toast = Toast.Make("Check In Date not valied", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.CheckOutDate < model.CheckInDate)
                {
                    var toast = Toast.Make("Check Out Date not valied", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.TotalNights == 0)
                {
                    var toast = Toast.Make("Total Nights is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.RatePerNight == 0)
                {
                    var toast = Toast.Make("Rate Per Night is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model.PaymentMethod))
                {
                    var toast = Toast.Make("Payment Method is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.TotalCost == 0)
                {
                    var toast = Toast.Make("Total Cost is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.RoomId == 0)
                {
                    var toast = Toast.Make("Room Number is requierd", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else
                {
                    if (!string.IsNullOrEmpty(UserToken))
                    {
                        UserDialogs.Instance.ShowLoading();
                        var json = await Rep.PostTRAsync<BookingModel, BookingModel>(ApiConstants.RoomBookingApi, Booking, UserToken);
                        UserDialogs.Instance.HideHud();
                        if (json.Item1 != null)
                        {
                            
                        }
                    }
                }
            }
        }
    }
}
