﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared.User;
using EngHotel.ViewModels.Shared.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripBliss.Helpers;

namespace EngHotel.ViewModels.User.Shared
{
    public partial class UsersViewModel : BaseViewModel
    {
        #region Prop
        [ObservableProperty]
        ObservableCollection<UserModel> users = new ObservableCollection<UserModel>(); 
        #endregion

        #region Service
        readonly IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion
        public UsersViewModel(IGenericRepository GenericRep, Services.Data.ServicesService service)
        {
            Rep = GenericRep;
            _service = service;
            LoadData(); 
        }

        void LoadData()
        {
            Users.Add(new UserModel { EmployeeName = "Abdul Akil", Department = "Room Service" });
            Users.Add(new UserModel { EmployeeName = "Sarah Khan", Department = "Front Desk" });
            Users.Add(new UserModel { EmployeeName = "Ahmed Ali", Department = "Housekeeping" });
            Users.Add(new UserModel { EmployeeName = "Maria Silva", Department = "Food and Beverage" });
            Users.Add(new UserModel { EmployeeName = "James Smith", Department = "Maintenance" });
            Users.Add(new UserModel { EmployeeName = "Linda Brown", Department = "Human Resources" });
            Users.Add(new UserModel { EmployeeName = "Michael Jones", Department = "Security" });
            Users.Add(new UserModel { EmployeeName = "Emily Davis", Department = "Concierge" });
            Users.Add(new UserModel { EmployeeName = "John Wilson", Department = "IT Support" });
            Users.Add(new UserModel { EmployeeName = "Sophia Martinez", Department = "Event Planning" });

        }


        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        [RelayCommand]
        async Task AddUserClick()
        {
            var vm = new AddUserViewModel(Rep,_service);
            var page = new AddUserPage(vm);
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
