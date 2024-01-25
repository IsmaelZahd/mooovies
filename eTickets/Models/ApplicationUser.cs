using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 20 chars")]
        public string Name { get; set; }


        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Surname must be between 1 and 25 chars")]
        public string Surname { get; set; }

    }
}
