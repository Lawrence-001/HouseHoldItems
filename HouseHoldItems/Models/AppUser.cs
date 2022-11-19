using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HouseHoldItems.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

    }
}
