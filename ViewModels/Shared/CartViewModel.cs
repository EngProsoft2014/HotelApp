﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class CartViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<CartModel> carts = new ObservableCollection<CartModel>();

        public CartViewModel()
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
