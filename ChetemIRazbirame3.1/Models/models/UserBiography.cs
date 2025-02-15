using System.ComponentModel.DataAnnotations;

namespace ChetemIRazbirame3._1.Models.models
{
    public class UserBiography
    {
        [Key]
        public int Id { get; set; }
        public string BiographyData { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
