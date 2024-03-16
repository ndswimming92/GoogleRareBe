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
            app.MapPost("/api/addTag", (GoogleRareBeDbContext db, Tag addTag) =>
            {
                db.Tags.Add(addTag);
                db.SaveChanges();
                return Results.Ok();
            });

            // Get a Tag
            app.MapGet("/api/getTags", (GoogleRareBeDbContext db) => {
                return db.Tags.ToList();
            });

            // 
            app.MapPatch("/api/updateTags/{tagId}", (GoogleRareBeDbContext db, int tagId, Tag updateTag) =>
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

                return Results.Ok();
            });

            // Deleting a Tag

        }

    }

}

