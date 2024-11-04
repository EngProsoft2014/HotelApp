using CommunityToolkit.Mvvm.ComponentModel;
using EngHotel.Models;
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
                Name = "Maintenance  Service"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Luggage  Services"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Childcare  Service"
            });
            Carts.Add(new CartModel()
            {
                ItemCount = 1,
                Name = "Dining  Services"
            });

        }
    }
}
