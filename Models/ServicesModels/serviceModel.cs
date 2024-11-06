using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EngHotel.Models.ServicesModels
{
    public class serviceModel : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string? serviceName { get; set; }
        public object? serviceNameAr { get; set; }
        public object? serviceIcon { get; set; }
        public DateTime? createDate { get; set; }
        public List<CategoryModel>? categories { get; set; }

        private bool _isSelected;

        public bool isSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("isSelected")); // reports this property
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
