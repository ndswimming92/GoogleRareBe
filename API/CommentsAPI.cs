using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Xml.Linq;

namespace GoogleRareBe.API
{
    public static class CommentsAPI
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/api/comments/{postId}", (GoogleRareBeDbContext db, int postId) =>
            {
                Post post = db.Posts.SingleOrDefault(p => p.Id == postId);
                if (post == null)
                {
                    return Results.BadRequest("Invalid data submitted");
                }
                List<Comment> comments = db.Comments
                                                .Where(c => c.Post_id == postId)
                                                .OrderByDescending(c => c.Created_on)
                                                .ToList();
                if (comments.Count == 0)
                {
                    return null;
                }
                db.SaveChanges();
                return Results.Ok(comments);
            });

            /*delete comments by the comments id*/
            app.MapDelete("/api/deleteComment/{id}", (GoogleRareBeDbContext db, int id) =>
            {
                Comment deleteComment = db.Comments.SingleOrDefault(commentToDelete => commentToDelete.Id == id);
                if (deleteComment == null)
                {
                    return Results.NotFound();
                }
                db.Comments.Remove(deleteComment);
                db.SaveChanges();
                return Results.NoContent();
            });
            /*create comments*/
            app.MapPost("/api/createComment", (GoogleRareBeDbContext db, Comment comment) =>
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return Results.Created($"/api/users/{comment.Id}", comment);
            });
            // update a comment
            app.MapPut("api/updateComment/{id}", (GoogleRareBeDbContext db, int id, Comment comments) =>
            {
                var updateComment = db.Comments.SingleOrDefault(c => c.Id == id);
                if (updateComment == null)
                {
                    return Results.NotFound("User not found");
                }
                updateComment.Author_id = comments.Author_id;
                updateComment.Post_id = comments.Post_id;
                updateComment.Created_on = comments.Created_on;
                updateComment.Content = comments.Content;
                db.SaveChanges();
                return Results.NoContent();
            });


        }
    }
}
