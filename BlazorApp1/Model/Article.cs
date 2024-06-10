using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class Article
    {
        public int ArticleId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.Now;

        //külső kulcs foreign key
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
