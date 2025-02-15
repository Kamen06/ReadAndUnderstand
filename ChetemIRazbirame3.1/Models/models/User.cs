using System.ComponentModel.DataAnnotations;

namespace ChetemIRazbirame3._1.Models.models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15), Required]
        public string FirstName { get; set; }
        [MaxLength(15), Required]
        public string LastName { get; set; }

        public string ProfilePicture { get; set; }
        [Required]
        public string UserBiography { get; set; }

    }
}
