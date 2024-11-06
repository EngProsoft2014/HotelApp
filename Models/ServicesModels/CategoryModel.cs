using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.ServicesModels
{
    public class CategoryModel
    {
        public int? category_ID { get; set; }
        public int? service_ID { get; set; }
        public string? serviceName { get; set; }
        public string? categoryName { get; set; }
        public object? categoryNameAr { get; set; }
        public object? categoryIcon { get; set; }
        public bool? active { get; set; }
    }
}
