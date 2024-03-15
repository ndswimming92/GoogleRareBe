namespace GoogleRareBe.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Author_id { get; set; }
        public int Post_id { get; set; }
        public string Content { get; set; }
        public DateTime Created_on { get; set; }
    }
}
