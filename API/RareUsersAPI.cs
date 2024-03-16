using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class RareUsersAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("api/createUser", (GoogleRareBeDbContext db, User users) =>
            {
                db.Users.Add(users);
                db.SaveChanges();
                return Results.Created($"/api/createUser/{users.Id}", users);

            });

            app.MapPut("api/updateUser/{id}", (GoogleRareBeDbContext db, int id, User users) =>
            {
                DateTime modifyDate = DateTime.Now;
                User updateUser = db.Users.SingleOrDefault(users => users.Id == id);
                if (updateUser == null)
                {
                    return Results.NotFound("User not found");
                }
                updateUser.FirstName = users.FirstName;
                updateUser.LastName = users.LastName;
                updateUser.Bio = users.Bio;
                updateUser.PublicImageUrl = users.PublicImageUrl;
                updateUser.email = users.email;
                updateUser.CreatedOn = modifyDate;
                updateUser.Active = users.Active;
                updateUser.IsStaff = users.IsStaff;
                
                db.SaveChanges();
                return Results.NoContent();
            });

            app.MapGet("api/users/{id}", (GoogleRareBeDbContext db, int id) =>
            {
                var userDetails = db.Users
                .FirstOrDefault(users => users.Id == id);

                if (userDetails == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(userDetails);
            });

            app.MapGet("api/users", (GoogleRareBeDbContext db) =>
            {
                return db.Users.ToList();
            });
        
        }
    }
}
