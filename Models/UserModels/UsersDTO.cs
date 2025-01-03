﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models.UserModels
{
    public class UsersDTO
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? NewPassword { get; set; }
        public string? PINNumber { get; set; }
        public string? Country { get; set; }
        public string? Role { get; set; } = "0";
        public int Type { get; set; } = 0; // Guest = 0 , Employee = 1
        public string? Token { get; set; }
        public int ExpiresIn { get; set; }
        public List<UserServicesDTO>? lstUserServices { get; set; } = new List<UserServicesDTO>();
    }
}
