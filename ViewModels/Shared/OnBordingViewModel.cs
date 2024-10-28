using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class OnBordingViewModel : BaseViewModel
    {

        [RelayCommand]
        async Task LoginCLick()
        {
            var vm = new LoginViewModel();
            var page = new LoginPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }

        [RelayCommand]
        async Task LoginAsaGuestCLick()
        {
            var vm = new LoginAsaGuestViewModel();
            var page = new LoginAsAGuestPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
