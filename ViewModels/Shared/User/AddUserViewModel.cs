using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Controls.UserDialogs.Maui;
using EngHotel.Constants;
using EngHotel.Models;
using EngHotel.Models.ServicesModels;
using EngHotel.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared.User
{
    public partial class AddUserViewModel : BaseViewModel
    {
        #region Prop
        [ObservableProperty]
        ObservableCollection<serviceModel> services = new ObservableCollection<serviceModel>();
        [ObservableProperty]
        UsersDTO usersRequest = new UsersDTO();
        #endregion

        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        public AddUserViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service)
        {
            Rep = GenericRep;
            _service = service;
            Init();
        }

        #region RelayCommand
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        public void AddService(serviceModel model)
        {
            model.isSelected = !model.isSelected;
            if (model.isSelected)
            {
                UsersRequest.lstUserServices!.Add(new UserServicesDTO { Service_ID = model.id });
            }
            else
            {
                var cc = UsersRequest.lstUserServices!.FirstOrDefault(a => a.Service_ID == model.id);
                if (cc != null)
                {
                    UsersRequest.lstUserServices!.Remove(cc);
                }
            }
        }

        async Task SignUpClick(UsersDTO model)
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if (string.IsNullOrEmpty(model?.FirstName))
                {
                    var toast = Toast.Make("Name is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
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
                else if (string.IsNullOrEmpty(model?.Password))
                {
                    var toast = Toast.Make("Password is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (string.IsNullOrEmpty(model?.PINNumber))
                {
                    var toast = Toast.Make("PIN Number is Required", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else if (model.lstUserServices!.Count == 0)
                {
                    var toast = Toast.Make("Add at least 1 service.", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else
                {
                    IsBusy = false;
                    UserDialogs.Instance.ShowLoading();
                    string UserToken = await _service.UserToken();
                    var json = await Rep.PostTRAsync<UsersDTO, UsersDTO>(ApiConstants.RegisterApi, UsersRequest);
                    if (json.Item1 != null)
                    {
                        UsersRequest = json.Item1;

                        if (UsersRequest.User_ID != 0 && UsersRequest.User_ID != null)
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
        #endregion

        #region Method
        async void Init()
        {
            await LoadServicesData();
        }
        async Task LoadServicesData()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                string UserToken = await _service.UserToken();
                if (string.IsNullOrEmpty(UserToken))
                {
                    UserDialogs.Instance.ShowLoading();
                    var json = await Rep.GetAsync<ObservableCollection<serviceModel>>(ApiConstants.GetAllSevicesApi, UserToken);
                    UserDialogs.Instance.HideHud();
                    if (json != null)
                    {
                        Services = json;
                    }
                }
            }
        }

        #endregion
    }
}
