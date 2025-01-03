﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class ResetViewModel : BaseViewModel
    {
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        [RelayCommand]
        async Task SendMessageClick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
    }
}
