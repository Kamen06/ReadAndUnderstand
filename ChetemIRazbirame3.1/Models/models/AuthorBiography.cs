using System.ComponentModel.DataAnnotations;

namespace ChetemIRazbirame3._1.Models.models
{
    public class AuthorBiography
    {
        [Key]
        public int Id { get; set; }
        public string BiographyData { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
