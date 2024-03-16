using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class PostsAPI
    {
        public static void Map(WebApplication app)
        {
            // Create Post
            app.MapPost("/api/createPosts", (GoogleRareBeDbContext db, Post newPost) =>
            {
                db.Posts.Add(newPost);
                db.SaveChanges();
                return Results.Created($"/api/createPosts/{newPost.Id}", newPost);
            });

            // Read Post
            app.MapGet("/api/readPosts", (GoogleRareBeDbContext db) =>
            {
                return db.Posts.ToList();
            });

            // Update Post
            app.MapPut("/api/updatePosts/{id}", (GoogleRareBeDbContext db, int id, Post post) =>
            {
                Post postToUpdate = db.Posts.SingleOrDefault(post => post.Id == id);
                if (postToUpdate == null)
                {
                    return Results.NotFound();
                }
                postToUpdate.Title = post.Title;
                postToUpdate.CategoryId = post.CategoryId;
                postToUpdate.PublicationDate = post.PublicationDate;
                postToUpdate.ImageUrl = post.ImageUrl;
                postToUpdate.Content = post.Content;
                postToUpdate.Approved = post.Approved;

                db.SaveChanges();
                return Results.NoContent();
            });

            // Delete Post
            app.MapDelete("/api/deletePosts/{id}", (GoogleRareBeDbContext db, int id) =>
            {
                Post postToDelete = db.Posts.SingleOrDefault(post => post.Id == id);
                if (postToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Posts.Remove(postToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
