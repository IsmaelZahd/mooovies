using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 20 chars")]
        public string Name { get; set; }


        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Surname must be between 1 and 25 chars")]
        public string Surname { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
