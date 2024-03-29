﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserWeb.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Tài khoản")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
