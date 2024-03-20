using GoogleRareBe.Data;
using GoogleRareBe.DTO;
using GoogleRareBe.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace GoogleRareBe.API
{
    public static class PostTagAPI
    {
        public static void Map(WebApplication app)
        {
            // Endpoints

            // add tag to post
            app.MapPut("/api/posts/{postId}/tag", (GoogleRareBeDbContext db, PostTagsDTO postTags) =>
            {
                Post post = db.Posts
                              .Include(p => p.Tags)
                              .SingleOrDefault(p => p.Id == postTags.PostId);
                Tag tag = db.Tags
                            .SingleOrDefault(t => t.Id == postTags.TagId);
                if (post == null)
                {
                    return Results.BadRequest("Invalid data submitted");
                }
                try
                {
                    post.Tags.Add(tag);
                    db.SaveChanges();
                    return Results.Ok(postTags);
                }
                catch (ArgumentNullException)
                {
                    return Results.BadRequest("Tag not found");
                }
            });

        }

    }

}

