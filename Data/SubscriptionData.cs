using System;
using GoogleRareBe.Models;
namespace GoogleRareBe.Data
{
    public class SubscriptionData
    {
        public static List<Subscription> Categories = new List<Subscription>
        {
            new Subscription {Id = 1, Follower_id = 1, Author_id = 1, Created_on = DateTime.Now, Ended_on = DateTime.Now  },
            new Subscription {Id = 2, Follower_id = 2, Author_id = 2, Created_on = DateTime.Now, Ended_on = DateTime.Now  },
            new Subscription {Id = 3, Follower_id = 3, Author_id = 3, Created_on = DateTime.Now, Ended_on = DateTime.Now  },
            new Subscription {Id = 4, Follower_id = 4, Author_id = 4, Created_on = DateTime.Now, Ended_on = DateTime.Now  },
        };
    }
}

