using System.ComponentModel.DataAnnotations;

namespace ChetemIRazbirame3._1.Models.models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Title { get; set; }
        [Required, MaxLength(15)]
        public string Genre { get; set; }
        [Required, MaxLength(250)]
        public string Summary { get; set; }
        [Required]
        public int AuthorId { get; set; }
       
        public virtual Author Author { get; set; }
        [Required]
        public List<Review> Reviewes { get; set; }



    }
}
