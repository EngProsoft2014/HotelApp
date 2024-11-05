using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Orders.OrderDetails;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Orders.OrderDetails
{
    public partial class OrderDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<CartModel> carts = new ObservableCollection<CartModel>();

        public OrderDetailsViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Room Service"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Bathroom Services"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Housekeeping Services"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Laundry Services"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Maintenance Service"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Luggage Services"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Childcare Service"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Dining Services"
            });

        }
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task SelectClick(CartModel model)
        {
            if (model.Name == "Room Service")
            {
                var vm = new RoomServiceDetailsViewModel();
                var page = new RoomServiceDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Bathroom Services")
            {
                var vm = new BathroomServicesDetailsViewModel();
                var page = new BathroomServicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Housekeeping Services")
            {
                var vm = new HousekeepingServicesDetailsViewModel();
                var page = new HousekeepingServicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Laundry Services")
            {
                var vm = new LaundryServicesDetailsViewModel();
                var page = new LaundryServicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Maintenance Service")
            {
                var vm = new MaintenanceServicesDetailsViewModel();
                var page = new MaintenanceServicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Luggage Services")
            {
                var vm = new LuggageServicesDetailsViewModel();
                var page = new LuggageServicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Childcare Service")
            {
                var vm = new ChildcareServicesDetailsViewModel();
                var page = new ChildcareServicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
            else if (model.Name == "Dining Services")
            {
                var vm = new DiningServicesDetailsViewModel();
                var page = new DiningSevicesDetailsPage();
                page.BindingContext = vm;
                await App.Current!.MainPage!.Navigation.PushAsync(page);
            }
        }


    }
}
