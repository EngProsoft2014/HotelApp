using CommunityToolkit.Mvvm.ComponentModel;
using EngHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class HistoryViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<HistoryModel> history = new ObservableCollection<HistoryModel>();
        public HistoryViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            History.Add(new HistoryModel()
            {
                EmplyeeId = 1,
                Date = DateTime.Now.AddDays(-4),
                Time = DateTime.Now.AddMinutes(-520),
                Statues = "Compleated"
            });

            History.Add(new HistoryModel()
            {
                EmplyeeId = 2,
                Date = DateTime.Now.AddDays(-3),
                Time = DateTime.Now.AddMinutes(-400),
                Statues = "Pending"
            });

            History.Add(new HistoryModel()
            {
                EmplyeeId = 3,
                Date = DateTime.Now.AddDays(-2),
                Time = DateTime.Now.AddMinutes(-250),
                Statues = "Progress"
            });

            History.Add(new HistoryModel()
            {
                EmplyeeId = 4,
                Date = DateTime.Now.AddDays(-1),
                Time = DateTime.Now.AddMinutes(-180),
                Statues = "Compleated"
            });

            History.Add(new HistoryModel()
            {
                EmplyeeId = 5,
                Date = DateTime.Now,
                Time = DateTime.Now.AddMinutes(-60),
                Statues = "Pending"
            });

        }
    }
}
