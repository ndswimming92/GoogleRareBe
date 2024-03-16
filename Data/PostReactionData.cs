using GoogleRareBe.Models;
namespace GoogleRareBe.Data
{
    public class PostReactionData
    {
        public static List<PostReaction> PostReactions = new List<PostReaction>
        {
            new PostReaction
            {
                Id = 1,
                rareUserId = 1,
                postId = 1,
                reactionId = 1,
            },
            new PostReaction 
            { 
                Id = 2, 
                rareUserId = 2,
                postId = 2,
                reactionId = 2,
            },
            new PostReaction
            {
                Id = 3,
                rareUserId = 3,
                postId = 3,
                reactionId = 3,
            },
            new PostReaction
            {
                Id = 4,
                rareUserId = 4,
                postId = 4,
                reactionId = 4,
            },
        };
    }
}
