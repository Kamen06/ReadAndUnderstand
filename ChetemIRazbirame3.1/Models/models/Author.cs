using System.ComponentModel.DataAnnotations;
using Windows.UI.Xaml.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;


namespace ChetemIRazbirame3._1.Models.models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
       
        [MaxLength(15),Required]
        public string FirstName { get; set; }

        [MaxLength(15), Required]
        public string LastName { get; set; }
        [Required]
        public bool Deceased { get; set; }

        [Display(Name = "Снимка")]
        public string? ProfilePicture { get; set; }

        [Required]
        public string Biography { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
