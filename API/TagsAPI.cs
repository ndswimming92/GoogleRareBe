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

        }

    }

}

