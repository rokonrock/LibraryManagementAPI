using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        public int AuthorId { get; set; }
        public bool IsBorrowed { get; set; }
    }
}
