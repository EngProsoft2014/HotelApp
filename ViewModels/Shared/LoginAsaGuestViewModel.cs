using Akavache;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Controls.UserDialogs.Maui;
using EngHotel.Constants;
using EngHotel.Models.UserModels;
using EngHotel.Pages.Shared;
using EngHotel.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared
{
    public partial class LoginAsaGuestViewModel : BaseViewModel
    {
        #region Services
        IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        #region Prop
        [ObservableProperty]
        public string pinNumber = "";
        [ObservableProperty]
        public UsersDTO userResponse = new UsersDTO(); 
        #endregion

        public LoginAsaGuestViewModel(IGenericRepository generic, Services.Data.ServicesService service)
        {
            Rep = generic;
            _service = service;
        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task LoginClick(string pass)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if (string.IsNullOrEmpty(pass))
                {
                    var toast = Toast.Make("Pin Number is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else
                {
                    IsBusy = true;
                    UserDialogs.Instance.ShowLoading();

                    //model.UserName = model.UserName.ToLower();
                    //model.Password = model.Password.ToLower();
                    string uri = $"{ApiConstants.LoginByPinApi}Pinnumber={pass}";
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
                            var page = new HomePage(Rep,_service);
                            page.BindingContext = vm;
                            await App.Current!.MainPage!.Navigation.PushAsync(page);
                            await BlobCache.LocalMachine.InsertObject(ServicesService.UserTokenServiceKey, UserResponse?.Token, DateTimeOffset.Now.AddMinutes(43200));

                        }
                        else
                        {
                            var vm = new LoginAsaGuestViewModel(Rep, _service);
                            var page = new LoginAsAGuestPage();
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
