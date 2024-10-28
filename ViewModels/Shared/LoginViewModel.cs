using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
     public partial class LoginViewModel : BaseViewModel
    {

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task SignUpClick()
        {
            var vm = new SignUpViewModel();
            var page = new SignUpPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }

        [RelayCommand]
        async Task ForgetPasswordClick()
        {
            var vm = new ResetViewModel();
            var page = new ResetPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
