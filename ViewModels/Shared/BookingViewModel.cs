using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared.Rooms;
using EngHotel.ViewModels.Shared.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared
{
    public partial class BookingViewModel : BaseViewModel
    {
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
            var vm = new RoomFilterViewModel(Rep,_service);
            var page = new RoomFilterPage(vm);
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
