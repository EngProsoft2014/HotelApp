using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared.Rooms
{
    public partial class ImagesViewModel :BaseViewModel  
    {
        [ObservableProperty]
        ObservableCollection<string> lstSt = new ObservableCollection<string>();

        public ImagesViewModel()
        {
            LoadData();
        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        void LoadData()
        {
            LstSt.Add("jjjj");
            LstSt.Add("jjjj");
            LstSt.Add("jjjj");
            LstSt.Add("jjjj");
            LstSt.Add("jjjj");
            LstSt.Add("jjjj");
        }
    }
}
