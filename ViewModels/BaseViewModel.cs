using CommunityToolkit.Mvvm.ComponentModel;
using EngHotel.Constants;

namespace EngHotel.ViewModels
{
    public partial class BaseViewModel: ObservableObject
    {
        public BaseViewModel()
        {

        }

        [ObservableProperty]
        public bool isBusy = true;

        [ObservableProperty]
        public string lang;


    }
}
