using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VetChat.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        public string Contact { get; internal set; }
        public string Branch { get; internal set; }
        public DateTime DateOfEntry { get; internal set; }
        public DateTime Ets { get; internal set; }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        public byte[] UserPhoto { get; set; }
>>>>>>> Stashed changes
=======
        public byte[] UserPhoto { get; set; }
>>>>>>> Stashed changes
    }
}
