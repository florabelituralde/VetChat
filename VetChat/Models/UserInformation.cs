using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VetChat.Data
{
    public partial class UserInformation
    {
        public UserInformation()
        {
            AdminData = new HashSet<AdminData>();
            GroupData = new HashSet<GroupData>();
        }

        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Contact { get; set; }
        public string Branch { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Entry")]
        public DateTime DateOfEntry { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "ETS Date")]
        public DateTime Ets { get; set; }

        public virtual ICollection<AdminData> AdminData { get; set; }
        public virtual ICollection<GroupData> GroupData { get; set; }
    }
}