using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class TagsAPI
    {
        public static void Map(WebApplication app)
        {
            // Endpoints

            // Add Tag
            app.MapPost("/api/createTag", (GoogleRareBeDbContext db, Tag createTag) =>
            {
                db.Tags.Add(createTag);
                db.SaveChanges();
                return Results.Created($"/api/addTag/{createTag.Id}", createTag);
            });

            // Get a Tag
            app.MapGet("/api/getTags", (GoogleRareBeDbContext db) => {
                return db.Tags.ToList();
            });

            // Updating a Tag
            app.MapPut("/api/updateTags/{tagId}", (GoogleRareBeDbContext db, int tagId, Tag updateTag) =>
            {
                var editedTag = db.Tags.FirstOrDefault(t => t.Id == tagId);
                if (editedTag == null)
                {
                    return Results.NotFound();
                }

                if (updateTag.Label != null)
                {
                    editedTag.Label = updateTag.Label.ToString();
                }

                db.SaveChanges();
                return Results.Ok();
            });

            // Deleting a Tag
            app.MapDelete("/api/deleteTags/{tagId}", (GoogleRareBeDbContext db, int tagId) =>
            {
                try
                {
                    var tagToDelete = db.Tags.FirstOrDefault(t => t.Id == tagId);
                    db.Tags.Remove(tagToDelete);
                    db.SaveChanges();
                    return Results.Ok();
                }
                catch
                {
                    return Results.NotFound();
                }
            });
        }

    }

}

