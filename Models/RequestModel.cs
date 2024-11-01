using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models
{
    public class RequestModel
    {
        public int RoomId { get; set; }
        public string? GuestName { get; set; }
        public string? Status { get; set; }
        public DateTime Date { get; set; }
    }
}
