using CommunityToolkit.Mvvm.Input;
using EngHotel.Pages.Shared;
using EngHotel.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class OpenBofaDetailsViewModel : BaseViewModel
    {
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task NotesClick()
        {
            var vm = new NotesViewModel();
            var page = new NotesPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
