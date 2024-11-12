using EngHotel.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.BookingModels
{
    public class BookingModel : INotifyPropertyChanged
    {
        private int _roomId;
        private DateTime _checkInDate = DateTime.Now.AddDays(1);
        private DateTime _checkOutDate = DateTime.Now.AddDays(2);

        public int Booking_ID { get; set; }
        public string? Reference_Number { get; set; }
        public int Account_ID { get; set; } = Preferences.Default.Get(ApiConstants.userid,0);
        public int RoomId
        {
            get => _roomId;
            set
            {
                if (_roomId != value)
                {
                    _roomId = value;
                    OnPropertyChanged(nameof(RoomId)); // reports this property
                }
            }
        }
        public DateTime BookingDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime CheckInDate
        {
            get => _checkInDate;
            set
            {
                if (_checkInDate != value)
                {
                    _checkInDate = value;
                    OnPropertyChanged(nameof(CheckInDate));
                    OnPropertyChanged(nameof(TotalNights)); // Update TotalNights when CheckInDate changes
                }
            }
        }
        public DateTime CheckOutDate
        {
            get => _checkOutDate;
            set
            {
                if (_checkOutDate != value)
                {
                    _checkOutDate = value;
                    OnPropertyChanged(nameof(CheckOutDate));
                    OnPropertyChanged(nameof(TotalNights)); // Update TotalNights when CheckOutDate changes
                }
            }
        }
        public string? BookingStatus { get; set; } = "Ava";
        public string? GuestName { get; set; }
        public string? GuestContact { get; set; }
        public string? NumberofGuests { get; set; }
        public string? SpecialRequests { get; set; }
        public decimal RatePerNight { get; set; }
        public int TotalNights => (CheckOutDate - CheckInDate).Days;
        public string? PaymentMethod { get; set; }
        public decimal TotalCost { get; set; }
        public bool Default { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
