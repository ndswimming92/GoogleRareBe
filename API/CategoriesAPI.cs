using GoogleRareBe.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleRareBe.API
{
    public static class CategoriesAPI
    {
        public static void Map(WebApplication app)
        {
            // Create Category
            app.MapPost("/api/categories", (GoogleRareBeDbContext db, Category newCategory) =>
            {
                db.Categories.Add(newCategory);
                db.SaveChanges();
                return Results.Created($"/api/categories/{newCategory.Id}", newCategory);
            });

            // Read Category
            app.MapGet("/api/categories", (GoogleRareBeDbContext db) =>
            {
                return db.Categories.ToList();
            });

            // Update Category
            app.MapPut("/api/categories/{id}", (GoogleRareBeDbContext db, int id, Category category) =>
            {
                Category categoryToUpdate = db.Categories.SingleOrDefault(category => category.Id == id);
                if (categoryToUpdate == null)
                {
                    return Results.NotFound();
                }
                categoryToUpdate.Label = category.Label;

                db.SaveChanges();
                return Results.NoContent();
            });

            // Delete Category
            app.MapDelete("/api/categories/{id}", (GoogleRareBeDbContext db, int id) =>
            {
                Category categoryToDelete = db.Categories.SingleOrDefault(category => category.Id == id);
                if (categoryToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
