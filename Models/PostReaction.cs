namespace GoogleRareBe.Models
{
    public class PostReaction
    {
        public int Id { get; set; }
        public int rareUserId { get; set; }
        public int postId { get; set; }
        public int reactionId { get; set; }
    }
}
