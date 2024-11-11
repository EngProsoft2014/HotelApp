using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Controls.UserDialogs.Maui;
using EngHotel.Constants;
using EngHotel.Models.RoomModels;
using EngHotel.Pages.Shared.Rooms;
using System.Collections.ObjectModel;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.Shared.Rooms
{
    public partial class RoomFilterViewModel : BaseViewModel 
    {
        #region Prop
        [ObservableProperty]
        RoomsFilter roomFilterModel = new RoomsFilter();
        [ObservableProperty]
        ObservableCollection<RoomModel> rooms = new ObservableCollection<RoomModel>();
        [ObservableProperty]
        ObservableCollection<string> bedType = new ObservableCollection<string>();
        [ObservableProperty]
        ObservableCollection<string> roomView = new ObservableCollection<string>();
        [ObservableProperty]
        ObservableCollection<string> roomType = new ObservableCollection<string>();
        [ObservableProperty]
        ObservableCollection<string> roomSize = new ObservableCollection<string>();
        [ObservableProperty]
        string selectedBedType = "";
        [ObservableProperty]
        string selectedRoomView = "";
        [ObservableProperty]
        string selectedRoomSize = "";
        public delegate void RoomDelegte(RoomModel model);
        public event RoomDelegte RoomFilterClose;
        #endregion

        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion

        #region Cons
        public RoomFilterViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service,DateTime ChecIn, DateTime ChecOut)
        {
            _service = service;
            Rep = GenericRep;
            //RoomFilterModel.desiredCheckInDate = ChecIn;
            //RoomFilterModel.desiredCheckOutDate = ChecOut;
            LoadData();
        } 
        #endregion

        #region RelayCommand
        [RelayCommand]
        async Task ImageClick()
        {
            var vm = new ImagesViewModel(true);
            var page = new ImagesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        [RelayCommand]
        async Task ImageDoneClick()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                string UserToken = await _service.UserToken();
                if (string.IsNullOrEmpty(SelectedRoomSize) && string.IsNullOrEmpty(SelectedRoomView) && string.IsNullOrEmpty(SelectedBedType))
                {
                    var toast = Toast.Make("Select at Least One Choose", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                    await toast.Show();
                }
                else
                {
                    RoomFilterModel.RoomSize = SelectedRoomSize;
                    //RoomFilterModel.RoomView = SelectedRoomView;
                    //RoomFilterModel.BedType = SelectedBedType;
                    if (!string.IsNullOrEmpty(UserToken))
                    {
                        UserDialogs.Instance.ShowLoading();
                        var json = await Rep.PostTRAsync<RoomsFilter, ObservableCollection<RoomModel>>(ApiConstants.GetRoomFilterApi, RoomFilterModel, UserToken);
                        UserDialogs.Instance.HideHud();
                        if (json.Item1 != null)
                        {
                            Rooms = json.Item1;
                        }
                    }
                }
            }
        }
        [RelayCommand]
        async Task SelectRoomClick(RoomModel room)
        {
            RoomFilterClose.Invoke(room);
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        #endregion

        #region Methods
        void LoadData()
        {
            // Add Lst Bed Type
            BedType.Add("Single Bed");
            BedType.Add("Twin Bed");
            BedType.Add("Double Bed");
            BedType.Add("Queen Bed");
            BedType.Add("King Bed");
            BedType.Add("Full Bed");
            // Add Lst Room View
            RoomView.Add("Haram View");
            RoomView.Add("City View");
            RoomView.Add("Kaaba View");
            // Add Lst Room Type
            RoomType.Add("Single Room");
            RoomType.Add("Double Room");
            RoomType.Add("Twin Room");
            RoomType.Add("Triple Room");
            RoomType.Add("Quad Room");
            RoomType.Add("Queen Room");
            RoomType.Add("King Room");
            RoomType.Add("Junior Suite");
            RoomType.Add("Executive Suite");
            // Add Lst Room Size
            RoomSize.Add("1200");
        }

        #endregion
    }
}
