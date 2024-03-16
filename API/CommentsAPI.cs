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
            /*get comments by post_id*/
            app.MapGet("/api/getComment/bypost", (GoogleRareBeDbContext db, int PostId) =>
            {
                var comByPost = db.Comments.Where(c => c.Post_id == PostId).ToList();
                if (comByPost.Count == 0)
                {
                    return Results.NotFound("No comments found for this post.");
                }
                return Results.Ok(comByPost);
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
                Comment updateComment = db.Comments.SingleOrDefault(c => c.Id == id);
                if (updateComment == null)
                {
                    return Results.NotFound("User not found");
                }
                updateComment.Content = comments.Content;
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
