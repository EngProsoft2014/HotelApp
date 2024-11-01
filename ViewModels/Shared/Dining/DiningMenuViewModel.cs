using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using EngHotel.Pages.Shared.Dining;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared.Dining
{
    public partial class DiningMenuViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<MealModel> meals = new ObservableCollection<MealModel>();

        public DiningMenuViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            Meals.Add(new MealModel { MealName = "Grilled Chicken", Classfication = "Main Course" });
            Meals.Add(new MealModel { MealName = "Caesar Salad", Classfication = "Appetizer" });
            Meals.Add(new MealModel { MealName = "Tomato Soup",  Classfication = "Soup" });
            Meals.Add(new MealModel { MealName = "Beef Steak", Classfication = "Main Course" });
            Meals.Add(new MealModel { MealName = "Fruit Salad", Classfication = "Dessert" });
            Meals.Add(new MealModel { MealName = "Garlic Bread", Classfication = "Appetizer" });
            Meals.Add(new MealModel { MealName = "Pasta Alfredo", Classfication = "Main Course" });
            Meals.Add(new MealModel { MealName = "Chocolate Cake", Classfication = "Dessert" });
            Meals.Add(new MealModel { MealName = "Lemonade", Classfication = "Beverage" });
            Meals.Add(new MealModel { MealName = "Vegetable Stir-Fry", Classfication = "Main Course" });

        }
        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }
        [RelayCommand]
        async Task AddDiningClick()
        {
            var vm = new AddDinigViewModel();
            var page = new AddDinigPage();
            page.BindingContext = vm;
            await App.Current!.MainPage!.Navigation.PushAsync(page);
        }
    }
}
