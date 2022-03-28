﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API_Weather.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public DateTime? UserBirthday { get; set; }
        public bool? UserGender { get; set; }
        public string UserPassword { get; set; }
        public DateTime? UserCreatedAt { get; set; }
    }
}
