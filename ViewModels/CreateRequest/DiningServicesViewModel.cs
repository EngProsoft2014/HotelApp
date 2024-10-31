using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.CreateRequest
{
    public partial class DiningServicesViewModel : BaseViewModel
    {




        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
    }
}
