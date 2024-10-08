﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Alikabook.Models
{
    public class CustomerInfo : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string? House { get; set; }
        public string? Barangay { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }

        //[RegularExpression(@"(^[0-9]*$|^$)", ErrorMessage = "Please enter a valid zipcode.")]
        public string? ZipCode { get; set; }
        public DateTime? Birthday { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;

        [NotMapped]
        //or [ValidateNever]
        public virtual ICollection<Comments> Comments { get; set; } = new List<Comments>();
        [NotMapped]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
