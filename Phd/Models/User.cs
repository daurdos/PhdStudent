﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Phd.Models
{
    public class User : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }


        [Display(Name = "Диссовет")]
        public int DisCouncilId { get; set; } // many Users - one Dissertation Council
        public DisCouncil DisCouncil { get; set; } // many Users - one Dissertation Council
        
    }
}