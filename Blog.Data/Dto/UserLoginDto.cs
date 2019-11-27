﻿using Blog.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.Data.Dto
{
    public class UserLoginDto
    {
        [Required,MinLength(6),MaxLength(355)]
        public string Email { get; set; }
        [Required, MinLength(8), MaxLength(32)]
        public string Password { get; set; }
    }
}
