using System.ComponentModel.DataAnnotations;

namespace ChetemIRazbirame3._1.Models.models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual UserBiography UserBiography { get; set; }

    }
}
