﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.RoomModels
{
    public class RoomsFilter
    {
        public DateTime desiredCheckOutDate { get; set; }
        public DateTime desiredCheckInDate { get; set; }
        public string? Status { get; set; } = "Available";
        public string? RoomSize { get; set; } = null;
        public string? BedType { get; set; } = null;
        public string? RoomView { get; set; } = null;
        public bool Has_Balcony { get; set; }
        public bool Has_Kitchenette { get; set; }
    }
}
