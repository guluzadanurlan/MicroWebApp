﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MicroWebApp.Models
{
    public partial class UsersPhoto
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
