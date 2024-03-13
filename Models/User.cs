using System;
using System.ComponentModel.DataAnnotations;

namespace GoogleRareBe.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string PublicImageUrl { get; set; }
        public string email { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
        public bool IsStaff { get; set; }
        public string Uid { get; set; }
    }
}
