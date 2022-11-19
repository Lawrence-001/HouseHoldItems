using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HouseHoldItems.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Fisrt Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action:"VerifyEmail", controller:"Account"  /*ErrorMessage ="Email is already taken"*/)]
        public string Email { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Minimum length is 6")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; }

    }
}

