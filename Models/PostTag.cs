using System.ComponentModel.DataAnnotations;

namespace GoogleRareBe.Models
{
    public class PostTag
    {
        public int Id { get; set; }
        [Required]
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
