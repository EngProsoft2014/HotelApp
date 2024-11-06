using Akavache;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Controls.UserDialogs.Maui;
using EngHotel.Constants;
using EngHotel.Helpers;
using EngHotel.Models.UserModels;
using EngHotel.Pages.Shared;
using EngHotel.Services.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared
{
     public partial class LoginViewModel : BaseViewModel
    {

        [ObservableProperty]
        public UserRequest request = new UserRequest();
        [ObservableProperty]
        public UsersDTO userResponse = new UsersDTO();

        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        public LoginViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service)
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
        async Task SignUpClick()
        {
            var vm = new SignUpViewModel(Rep,_service);
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

        [RelayCommand]
        async Task LoginClick(UserRequest model)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if (string.IsNullOrEmpty(model?.UserName))
                {
                    var toast = Toast.Make("User Name is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model?.Password))
                {
                    var toast = Toast.Make("Password is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else
                {
                    IsBusy = true;
                    UserDialogs.Instance.ShowLoading();

                    //model.UserName = model.UserName.ToLower();
                    //model.Password = model.Password.ToLower();
                    string uri = $"{ApiConstants.LoginApi}username={model.UserName}&password={model.Password}";
                    var json = await Rep.GetLoginAsync<UserRequest>(uri);

                    if (json != null)
                    {
                        UserResponse = json;

                        if (UserResponse.User_ID != 0 && UserResponse.User_ID != null)
                        {

                            Preferences.Default.Set(ApiConstants.userid, UserResponse!.User_ID);
                            Preferences.Default.Set(ApiConstants.email, UserResponse.Email);
                            Preferences.Default.Set(ApiConstants.PINNumber, UserResponse.PINNumber);
                            Preferences.Default.Set(ApiConstants.Role, UserResponse.Role);
                            Preferences.Default.Set(ApiConstants.Role, UserResponse.Role);
                            var vm = new HomeViewModel();
                            var page = new HomePage();
                            page.BindingContext = vm;
                            await App.Current!.MainPage!.Navigation.PushAsync(page);
                            await BlobCache.LocalMachine.InsertObject(ServicesService.UserTokenServiceKey, UserResponse?.Token, DateTimeOffset.Now.AddMinutes(43200));

                        }
                        else
                        {
                            var vm = new LoginViewModel(Rep, _service);
                            var page = new LoginPage();
                            page.BindingContext = vm;
                            await App.Current!.MainPage!.Navigation.PushAsync(page);
                            App.Current.MainPage.Navigation.RemovePage(App.Current.MainPage.Navigation.NavigationStack[App.Current.MainPage.Navigation.NavigationStack.Count - 2]);
                        }
                    }

                    UserDialogs.Instance.HideHud();
                    IsBusy = false;
                }
            }

        }
    }
}
