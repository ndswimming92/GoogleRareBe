using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class ReactionsAPI
    {
        public static void Map(WebApplication app)
        {
            /*get all reactions*/
            app.MapGet("/api/reactions", (GoogleRareBeDbContext db) =>
            {
                return db.Reactions.ToList();
            });

            /*get reactions by ID*/
            app.MapGet("/api/reactions/{id}", (GoogleRareBeDbContext db, int id) =>
            {
                var rID = db.Reactions.FirstOrDefault(r => r.Id == id);

                if (rID == null)
                {
                    return Results.NotFound("User not found.");
                }
                return Results.Ok(rID);
            });
        }
    }
}
