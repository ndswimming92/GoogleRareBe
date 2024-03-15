using GoogleRareBe.Models;
using System.Collections.Generic;

namespace GoogleRareBe.Data
{
    public class CommentData
    {
        public static List<Comment> Comments = new List<Comment>
        {
            new Comment
            {
                Id = 1,
                Author_id = 1,
                Post_id = 1,
                Content = "Howdley Doodley",
                Created_on = DateTime.Now,
            },

            new Comment
            {
                Id = 2,
                Author_id = 2,
                Post_id = 2,
                Content = "This is a comment that will be changed soon",
                Created_on = DateTime.Now,
            },
            new Comment
            {
                Id = 3,
                Author_id = 3,
                Post_id = 3,
                Content = "Death metal is really good :)",
                Created_on = DateTime.Now,
            }
        };
    }
}


