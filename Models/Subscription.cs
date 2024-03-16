namespace GoogleRareBe.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int Follower_id { get; set; }
        public int Author_id { get; set; }
        public DateTime Created_on { get; set; }
        public DateTime Ended_on { get; set; }
    }
}
