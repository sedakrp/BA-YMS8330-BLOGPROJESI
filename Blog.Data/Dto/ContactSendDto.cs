﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.Data.Dto
{
    public class ContactSendDto
    {
        [Required, MinLength(2),MaxLength(50)]
        public string Name { get; set; }
       [Required, MinLength(2), MaxLength(50)]
        public string Surname { get; set; }

        [Required, MinLength(3), MaxLength(500)]
        public string Message { get; set; }
    }
}
