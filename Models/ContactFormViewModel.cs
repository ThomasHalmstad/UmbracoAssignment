﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoAssignment.Models
{
    public class ContactFormViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address...")]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}