using System.ComponentModel.DataAnnotations;
using Windows.UI.Xaml.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;


namespace ChetemIRazbirame3._1.Models.models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(15)]
        public string FirstName { get; set; }

        [MaxLength(15)]
        public string LastName { get; set; }
        public BitmapImage ProfilePicture { get; set; }

        public virtual AuthorBiography? Biography { get; set; }
    }
}
