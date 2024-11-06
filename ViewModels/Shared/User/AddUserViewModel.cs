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
