using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Your_Archive.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }

        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public int Phonenumber { get; set; }
        
        public string Emailadres { get; set; }
        public string Wachtwoord { get; set; }
        
    }
}

