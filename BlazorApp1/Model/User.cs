using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class User
    {

        public int UserID { get; set; }

        [Required]
        [MaxLength (50)]
        public string?  UserName { get; set; }
        [MaxLength (100)]
        public string? Email { get; set; }

        //kapcsolat a másik táblához: egy falhasználónak több  cikke is lehet
        public ICollection<Article> Articles {get; set; }


    }
}
