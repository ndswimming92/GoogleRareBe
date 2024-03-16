using System.ComponentModel.DataAnnotations;

namespace GoogleRareBe.Models
{
    public class UserTypeChangeRequest
    {
        public int Id { get; set; }
        [Required]
        public string Action { get; set; }
        public int AdminOneId { get; set; }
        public int AdminTwoId { get; set; }
        public int ModifiedUserId { get; set; }
    }
}
