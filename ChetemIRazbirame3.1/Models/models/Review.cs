using System.ComponentModel.DataAnnotations;

namespace ChetemIRazbirame3._1.Models.models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        [MaxLength(200)]
        public string Text { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
