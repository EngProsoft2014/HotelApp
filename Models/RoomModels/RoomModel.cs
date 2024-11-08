using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.RoomModels
{
    public class RoomModel
    {
        public int Room_ID { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        public string? RoomSize { get; set; }
        public int MaxOccupancy { get; set; }
        public string? BedType { get; set; }
        public string? RoomView { get; set; }
        public bool Has_Balcony { get; set; }
        public bool Has_Kitchenette { get; set; }
        public string? RoomAccessibility { get; set; }
        public string? Status { get; set; }
        public List<RoomImages>? Images { get; set; }
    }
}
