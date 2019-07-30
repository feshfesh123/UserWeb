﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

}
