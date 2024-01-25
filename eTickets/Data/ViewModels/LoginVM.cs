using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        
        //[Required(ErrorMessage = "Password is required")] - default error message 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
