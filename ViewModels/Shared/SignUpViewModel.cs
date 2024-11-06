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
    public partial class SignUpViewModel : BaseViewModel
    {
        [ObservableProperty]
        UsersDTO userModel = new UsersDTO();

        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        public SignUpViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service)
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
        async Task SignUpClick(UsersDTO model)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if (string.IsNullOrEmpty(model?.FirstName))
                {
                    var toast = Toast.Make("First Name is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model?.LastName))
                {
                    var toast = Toast.Make("Last Name is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model?.Phone))
                {
                    var toast = Toast.Make("Phone is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model?.Email))
                {
                    var toast = Toast.Make("Email is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model?.Country))
                {
                    var toast = Toast.Make("Country is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
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
                    string UserToken = await _service.UserToken();
                    var json = await Rep.PostTRAsync<UsersDTO,UsersDTO>(ApiConstants.RegisterApi,UserModel);

                    if (json.Item1 != null)
                    {
                        UserModel = json.Item1;

                        if (UserModel.User_ID != 0 && UserModel.User_ID != null)
                        {

                            Preferences.Default.Set(ApiConstants.userid, UserModel!.User_ID);
                            Preferences.Default.Set(ApiConstants.email, UserModel.Email);
                            Preferences.Default.Set(ApiConstants.PINNumber, UserModel.PINNumber);
                            Preferences.Default.Set(ApiConstants.Role, UserModel.Role);
                            Preferences.Default.Set(ApiConstants.Role, UserModel.Role);
                            var vm = new HomeViewModel();
                            var page = new HomePage();
                            page.BindingContext = vm;
                            await App.Current!.MainPage!.Navigation.PushAsync(page);
                            await BlobCache.LocalMachine.InsertObject(ServicesService.UserTokenServiceKey, UserModel?.Token, DateTimeOffset.Now.AddMinutes(43200));

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
