using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.BookingModels
{
    public class BookingModel
    {
        public int Booking_ID { get; set; }
        public string? Reference_Number { get; set; }
        public int Account_ID { get; set; }
        public int RoomId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime CheckInDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime CheckOutDate { get; set; } = DateTime.Now.AddDays(2);
        public string? BookingStatus { get; set; }
        public string? GuestName { get; set; }
        public string? GuestContact { get; set; }
        public string? NumberofGuests { get; set; }
        public string? SpecialRequests { get; set; }
        public decimal RatePerNight { get; set; }
        public int TotalNights { get; set; }
        public string? PaymentMethod { get; set; }
        public decimal TotalCost { get; set; }
        public bool Default { get; set; }
    }
}
