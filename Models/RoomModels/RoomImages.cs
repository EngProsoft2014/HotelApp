﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.RoomModels
{
    public class RoomImages
    {
        public int Room_ID{ get; set; }
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }
        public bool Default { get; set; }
    }
}