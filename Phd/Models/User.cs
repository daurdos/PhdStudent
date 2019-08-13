using Microsoft.AspNetCore.Identity;
using System;

namespace Phd.Models
{
    public class User : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }


        
        public int DisCouncilId { get; set; } // many Users - one Dissertation Council
        public DisCouncil DisCouncil { get; set; } // many Users - one Dissertation Council
        
    }
}