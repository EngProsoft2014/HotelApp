using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared
{
    public partial class OnBordingViewModel : BaseViewModel
    {

        #region Services
        IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion
        public OnBordingViewModel(IGenericRepository generic, Services.Data.ServicesService service)
        {
            Rep = generic;
            _service = service;
        }

        [RelayCommand]
        async Task LoginCLick()
        {
            var vm = new LoginViewModel(Rep,_service);
            var page = new LoginPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }

        [RelayCommand]
        async Task LoginAsaGuestCLick()
        {
            var vm = new LoginAsaGuestViewModel(Rep,_service);
            var page = new LoginAsAGuestPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
