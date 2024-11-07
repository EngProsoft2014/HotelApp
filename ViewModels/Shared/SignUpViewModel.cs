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
                    IsBusy = false;
                    UserDialogs.Instance.ShowLoading();
                    string UserToken = await _service.UserToken();
                    var json = await Rep.PostTRAsync<UsersDTO,UsersDTO>(ApiConstants.RegisterApi,UserModel);
                    if (json.Item1 != null)
                    {
                        UserModel = json.Item1;

                        if (UserModel.ID != 0 && UserModel.ID != null)
                        {
                            var toast = Toast.Make("Account is created successfully", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                            await toast.Show();
                        }
                        else
                        {
                            var toast = Toast.Make("Error in Create Account", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                            await toast.Show();
                        }
                    }
                    UserDialogs.Instance.HideHud();
                    IsBusy = true;
                }
            }
        }
    }
}
